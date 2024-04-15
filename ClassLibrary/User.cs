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
            Saldo = 0;
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

        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Saldo { get => saldo; set => saldo = value; }
        public string Role { get => role; set => role = value; }
        public bool Is_enable { get => is_enable; set => is_enable = value; }

        public static User CekLogin(string email, string password)
        {
            Koneksi k = new Koneksi();
            string sql = "select email, password from users" +
                         " where email ='" + email + " 'AND password = SHA2('" + password + "',512)";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            while(hasil.Read()) 
            {
                User user = new User();
                user.Name = hasil.GetValue(0).ToString();
                user.Password = hasil.GetValue(1).ToString();
                return user;
            }
            return null;
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
            string sql = "insert into users(id, name, password, email, gender, noktp, imgktp) " +
                         "values ('" + u.Id + "','" + u.Name + "',SHA2('" + u.Password + "',512),'" +
                         "','" + u.Email + "','" + u.Gender + "','" + u.NoKtp + "','" + u.ImgKtp;
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
            List<Users> listUser = new List<Users>();
            while(hasil.Read() == true)
            {
                User user = new User();
                user.Id = int.Parse(hasil.GetValue(0).toString());
                user.Email = hasil.GetValue(1).ToString();
                user.Username = hasil.GetValue(2).ToString();
                user.Password = "";
                user.Nama = hasil.GetValue(4).ToString();
                user.Saldo = hasil.GetValue(5).ToString();
                user.Role = hasil.GetValue(6).ToString();
                user.Is_enable = hasil.GetValue(7).ToString();
                listUser.add(user);
            }
            return listUser;
        }
    }
}