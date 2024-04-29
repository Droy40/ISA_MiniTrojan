using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClassLibrary
{
    public class User
    {
        private int id;
        private string email;
        private string username;
        private string password;
        private string nama;
        private string saldo;
        private string role;
        private string foto_ktp;
        private bool is_enable;


        public User()
        {
            Id = 0;
            Email = "";
            Username = "";
            Password = "";
            Nama = "";
            Saldo = "";
            Role = "";
            Is_enable = false;
        }

        public User(int id, string email, string username, string password, string nama, string saldo, string role, bool is_enable, List<Transaksi> listOfTransaction)
        {
            Id = id;
            Email = email;
            Username = username;
            Password = password;
            Nama = nama;
            Saldo = saldo;
            Role = role;
            Is_enable = is_enable;
        }

        public int Id 
        { 
            get => id; 
            set => id = value; 
        }
        public string Email 
        { 
            get => AES.Decrypt(email, AES.key);
            set => email = AES.Encrypt(value, AES.key);
        }
        public string Username 
        { 
            get => AES.Decrypt(username, AES.key); 
            set => username = AES.Encrypt(value, AES.key); 
        }
        public string Password 
        { 
            get => password; 
            set => password = SHA.ComputeHash(value); 
        }
        public string Nama 
        { 
            get => AES.Decrypt(nama, AES.key); 
            set => nama = AES.Encrypt(value, AES.key); 
        }
        public string Saldo 
        { 
            get => AES.Decrypt(saldo, AES.key); 
            set => saldo = AES.Encrypt(value, AES.key); 
        }
        public string Role 
        { 
            get => AES.Decrypt(role, AES.key); 
            set => role = AES.Encrypt(value, AES.key); 
        }
        public bool Is_enable 
        { 
            get => is_enable; 
            set => is_enable = value; 
        }

        public static int CekLoginUsername(string username)
        {            
            string sql = "select * from users" +
                         " where username ='" + username + "';";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if(hasil.Read()) 
            {
                if (hasil.GetValue(7) == "0")
                {
                    throw new Exception("Akun tidak aktif");
                }
                else
                {
                    int idUser = hasil.GetInt16(0);
                    int sisaPercobaan = LoginLog.CekPercobaanLogin(idUser);
                    return sisaPercobaan;
                }
            }
            throw new Exception("username tidak ditemukan");
        }
        public static User CekLoginPassword(string username, string password)
        {
            string sql = "select * from users" +
                         " where username = '" +  username + "'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            
            if(hasil.Read())
            {
                // cek status disable/enable akun user
                if(hasil.GetValue(7) == "0")
                {
                    throw new Exception("Akun tidak aktif");
                }

                //cek sisa percobaan login
                int sisaPercobaan = LoginLog.CekPercobaanLogin(hasil.GetInt16(0));
                if(sisaPercobaan == 0)
                {
                    throw new Exception("Akun tidak aktif");
                }

                User user = new User();
                user.Id = int.Parse(hasil.GetValue(0).ToString());
                user.Email = hasil.GetValue(1).ToString();
                user.Username = hasil.GetValue(2).ToString();
                user.Nama = hasil.GetValue(4).ToString();
                user.Saldo = hasil.GetValue(5).ToString();
                user.Role = hasil.GetValue(6).ToString();
                user.Is_enable = hasil.GetBoolean(7);
                
                //cek password yg diinput dan catat percobaan login ke loginlog
                LoginLog loginLog = new LoginLog();
                if (hasil.GetValue(3) == password)
                {
                    loginLog.User = user;
                    loginLog.Status = true;
                    LoginLog.TambahData(loginLog);

                    return user;
                }
                else
                {
                    loginLog.User = user;
                    loginLog.Status = false;
                    LoginLog.TambahData(loginLog);
                    throw new Exception("Password salah");
                }
            }
            throw new Exception("username tidak ditemukan");
        }
        private static int GenerateIdUser()
        {
            string sql = "select max(id) from users";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if (hasil.Read() == true)
            {
                return int.Parse(hasil.GetValue(0).ToString()) + 1;
            }
            return 1;
        }
        public static bool TambahData(User u)
        {
            u.Id = GenerateIdUser();
            string sql = "insert into users(id, email, username, password, nama, saldo, role, is_enable) " +
                         "values ('" + u.Id + "','" + u.Email + "', '" + u.Username + "', SHA2('" + u.Password + "',512),'" +
                         "','" + u.Nama + "','" + u.Saldo + "','" + u.Role + "','" + u.Is_enable + "')";
            int jumlahDiubah = Koneksi.JalankanPerintahDML(sql);
            if(jumlahDiubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static List<User> BacaData(string filter = "", string nilai = "")
        {
            string sql;
            if(filter == "")
            {
                sql = "select * from users";
            }
            else
            {
                sql = "select * from users" +
                      " where " + filter + " like '%'" + nilai + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<User> listUser = new List<User>();
            while(hasil.Read() == true)
            {
                User user = new User();
                user.Id = int.Parse(hasil.GetValue(0).ToString());
                user.Email = hasil.GetValue(1).ToString();
                user.Username = hasil.GetValue(2).ToString();
                user.Nama = hasil.GetValue(4).ToString();
                user.Saldo = hasil.GetValue(5).ToString();
                user.Role = hasil.GetValue(6).ToString();
                user.Is_enable = hasil.GetBoolean(7);

                listUser.Add(user);
            }
            return listUser;
        }
    }
}