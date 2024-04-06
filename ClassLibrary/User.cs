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
        private string name;
        private string password;
        private string noHp;
        private string email;
        private string gender;
        private string noKtp;
        private string imgKtp;

        public User(int id, string name, string password, string email, string gender, string noKtp, string imgKtp)
        {
            Id = id;
            Name = name;
            Password = password;
            Email = email;
            Gender = gender;
            NoKtp = noKtp;
            ImgKtp = imgKtp;
        }
        public User()
        {
            Id = 1;
            Name = "";
            Password = "";
            Email = "";
            Gender = "";
            NoKtp = "";
            ImgKtp = "";
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string NoHp { get => noHp; set => noHp = value; }
        public string Email { get => email; set => email = value; }
        public string Gender { get => gender; set => gender = value; }
        public string NoKtp { get => noKtp; set => noKtp = value; }
        public string ImgKtp { get => imgKtp; set => imgKtp = value; }

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
    }
}