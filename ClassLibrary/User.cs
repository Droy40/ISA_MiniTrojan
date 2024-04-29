using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClassLibrary
{
    public class User
    {
        public int id;
        public string email;
        public string username;
        public string password;
        public string nama;
        public string saldo;
        public string role;
        public string foto_ktp;
        public bool is_enable;
        
        public User()
        {
            Id = 0;
            Email = "";
            Username = "";
            Password = "";
            Nama = "";
            Saldo = 0;
            Role = "";
            Is_enable = false;
        }

        public User(int id, string email, string username, string password, string nama, int saldo, string role, bool is_enable, List<Transaksi> listOfTransaction)
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
        public int Saldo 
        { 
            get => int.Parse(AES.Decrypt(saldo, AES.key)); 
            set => saldo = AES.Encrypt(value.ToString(), AES.key); 
        }
        public string Role 
        { 
            get => role; 
            set => role = value; 
        }
        public bool Is_enable 
        { 
            get => is_enable; 
            set => is_enable = value; 
        }

        public static bool CekLoginUsername(string username)
        {
            string sql = "select * from users where username =  '" + username+ "'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if(hasil.Read() == true)
            {
                if (hasil.GetBoolean(7) == true)
                {
                    if (LoginLog.CekPercobaanLogin(username) > 0)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception("Akun tidak aktif");
                    }
                }
                else
                {
                    throw new Exception("Akun tidak aktif");
                }
            }
            else
            {
                throw new Exception("Username tidak ditemukan");
            }
        }
        public static User CekLoginUsernamePassword(string username, string password)
        {

            int sisaPercobaan = LoginLog.CekPercobaanLogin(username);
            if (sisaPercobaan > 0)
            {
                string sql = "select * from users where username = '" + username + "' and password = '" + password + "'";
                MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
                LoginLog lg = new LoginLog();
                if (hasil.Read() == true)
                {
                    User u = new User();
                    u.Id = int.Parse(hasil.GetValue(0).ToString());
                    u.email = hasil.GetValue(1).ToString();
                    u.username = hasil.GetValue(2).ToString();
                    u.Password = hasil.GetValue(3).ToString();
                    u.nama = hasil.GetValue(4).ToString();
                    u.saldo = hasil.GetValue(5).ToString();
                    u.role = hasil.GetValue(6).ToString();
                    u.Is_enable = hasil.GetBoolean(7);

                    lg.User = u;
                    lg.Status = true;

                    LoginLog.TambahData(lg);
                    return u;
                }
                else
                {
                    if (sisaPercobaan == 1)
                    {
                        string sql2 = "update users set is_enable = 0 where username = '" + username + "'";
                        Koneksi.JalankanPerintahDML(sql2);
                    }
                    lg.User.username = username;
                    lg.Status = false;
                    LoginLog.TambahData(lg);
                    throw new Exception("Password salah");
                }

            }
            else
            {
                throw new Exception("Akun tidak aktif");
            }
            
        }
        private static int GenerateIdUser()
        {
            string sql = "select max(id) from users";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if (hasil.Read() == true)
            {
                if(hasil.GetValue(0) == DBNull.Value)
                {
                    return 1;
                }
                return int.Parse(hasil.GetValue(0).ToString()) + 1;
            }
            return 1;
        }
        public static bool TambahData(User u)
        {
            u.Id = GenerateIdUser();
            string isEnable = (u.is_enable == true) ? "1" : "0";
            string sql = "insert into users(id, email, username, password, nama, saldo, role, is_enable) " +
                         "values ('" + u.id + "','" + u.email + "', '" + u.username + "','" + u.password +
                         "','" + u.nama + "','" + u.saldo + "','" + u.role + "','" + isEnable  + "')";
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
                user.Saldo = hasil.GetInt32(5);
                user.Role = hasil.GetValue(6).ToString();
                user.Is_enable = hasil.GetBoolean(7);

                listUser.Add(user);
            }
            return listUser;
        }
    }
}