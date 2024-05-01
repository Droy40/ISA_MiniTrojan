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
        private string foto_ktp;
        public int sisa_percobaan_login;
        
        public User()
        {
            Id = 0;
            Email = "";
            Username = "";
            Password = "";
            Nama = "";
            Saldo = 0;
            Role = "";
            Sisa_percobaan_login = 3;
        }

        public User(int id, string email, string username, string password, string nama, double saldo, string role, int sisa_percobaan_login, List<Transaksi> listOfTransaction)
        {
            Id = id;
            Email = email;
            Username = username;
            Password = password;
            Nama = nama;
            Saldo = saldo;
            Role = role;
            Sisa_percobaan_login = sisa_percobaan_login;
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
        public double Saldo 
        { 
            get => double.Parse(AES.Decrypt(saldo, AES.key)); 
            set => saldo = AES.Encrypt(value.ToString(), AES.key); 
        }
        public string Role 
        { 
            get => role; 
            set => role = value; 
        }
        public int Sisa_percobaan_login 
        { 
            get => sisa_percobaan_login; 
            set => sisa_percobaan_login = value; 
        }
        public string Foto_ktp 
        { 
            set => foto_ktp = value; 
        }

        public static bool CekUsername(string username)
        {
            string sql = "select username, sisa_percobaan_login from users where username =  '" + AES.Encrypt(username,AES.key)+ "'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if(hasil.Read() == true)
            {
                if(hasil.GetInt16(1) == 0)
                {
                    throw new Exception("Akun tidak aktif");
                }
                else
                {
                    return true;
                }
            }
            else
            {
                throw new Exception("Username tidak ditemukan");
            }
        }
        public static User UserLogin(string username, string password)
        {
            string sql = "select * from users where username = '" + AES.Encrypt(username,AES.key) + "'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if (hasil.Read())
            {
                User u = new User();
                u.id = hasil.GetInt32(0);
                u.email = hasil.GetString(1);
                u.username = hasil.GetString(2);
                u.password = hasil.GetString(3);
                u.nama = hasil.GetString(4);
                u.saldo = hasil.GetString(5);
                u.Role = hasil.GetString(6);
                u.Sisa_percobaan_login = hasil.GetInt32(7);

                if (u.Sisa_percobaan_login == 0)
                {
                    throw new Exception("akun tidak aktif");
                }
                else if (u.Password == SHA.ComputeHash(password))
                {
                    string sql3 = "update users set sisa_percobaan_login = '3' where username = '" + AES.Encrypt(username, AES.key) + "'";
                    Koneksi.JalankanPerintahDML(sql3);
                    return u;
                }
                else
                {
                    string sql3 = "update users set sisa_percobaan_login = sisa_percobaan_login - 1 where username = '" + AES.Encrypt(username,AES.key) + "'";
                    Koneksi.JalankanPerintahDML(sql3);
                    throw new Exception("Password salah");
                }

            }
            throw new Exception("Username tidak ditemukan");
            
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
        public static bool Register(User u)
        {
            u.Id = GenerateIdUser();            
            string sql = "insert into users(id, email, username, password, nama, saldo, role, sisa_percobaan_login) " +
                         "values ('" + u.id + "','" + u.email + "', '" + u.username + "','" + u.password +
                         "','" + u.nama + "','" + u.saldo + "','" + u.role + "','" + u.Sisa_percobaan_login  + "')";
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
                user.Sisa_percobaan_login = hasil.GetInt16(7);

                listUser.Add(user);
            }
            return listUser;
        }
        //public static bool ActivateAcc(int id)
        //{
        //    List<User> list = User.BacaData();
        //}
    }
}