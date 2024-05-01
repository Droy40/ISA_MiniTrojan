using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Transactions;
using System.Configuration;

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
            Foto_ktp = "";
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
            get => foto_ktp;
            set => foto_ktp = value;
        }

        public static bool CekUsername(string username)
        {
            string sql = "select username, sisa_percobaan_login from users where username =  '" + AES.Encrypt(username, AES.key) + "'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if (hasil.Read() == true)
            {
                if (hasil.GetInt16(1) == 0)
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
            string sql = "select * from users where username = '" + AES.Encrypt(username, AES.key) + "'";
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
                    string sql3 = "update users set sisa_percobaan_login = sisa_percobaan_login - 1 where username = '" + AES.Encrypt(username, AES.key) + "'";
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
                if (hasil.GetValue(0) == DBNull.Value)
                {
                    return 1;
                }
                return int.Parse(hasil.GetValue(0).ToString()) + 1;
            }
            return 1;
        }
        public static bool Register(User u, string filePath = "")
        {
            u.Id = GenerateIdUser();
            string sql = "insert into users(id, email, username, password, nama, saldo, role, sisa_percobaan_login, photo_id_path) " +
                         "values ('" + u.id + "','" + u.email + "', '" + u.username + "','" + u.password +
                         "','" + u.nama + "','" + u.saldo + "','" + u.role + "','" + u.Sisa_percobaan_login + "','" + filePath + "')";
            int jumlahDiubah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDiubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static List<User> BacaDataUser(string filter = "", string nilai = "")
        {
            string sql = "select * from users where role = 'KONSUMEN'";
            if (filter != "")
            {
                sql += " AND " + filter + " = '" + AES.Encrypt(nilai, AES.key) + "'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<User> listUser = new List<User>();
            while (hasil.Read() == true)
            {
                User user = new User();
                user.Id = int.Parse(hasil.GetValue(0).ToString());
                user.email = hasil.GetValue(1).ToString();
                user.username = hasil.GetValue(2).ToString();
                user.nama = hasil.GetValue(4).ToString();
                user.saldo = hasil.GetString(5);
                user.role = hasil.GetValue(6).ToString();
                user.Foto_ktp = hasil.GetString(7).ToString();
                user.sisa_percobaan_login = hasil.GetInt16(8);

                listUser.Add(user);
            }
            return listUser;
        }

        public static bool AktivasiUser(User user)
        {
            string sql = "update users set sisa_percobaan_login = 3 where id = '" + user.Id + "'";
            int jumlahDiubah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDiubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static string SimpanGambar(User u, Image image)
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            ConfigurationSectionGroup userSetting = myConf.SectionGroups["userSettings"];

            var settingSection = userSetting.Sections["ISA_MiniTrojan.DbSettings"] as ClientSettingsSection;
            string path = settingSection.Settings.Get("photo_id_path").Value.ValueXml.InnerText;

            if (image != null)
            {
                image.Save(path + "\\users_" + u.Id);
                return "users_" + u.Id;
            }
            else
            {
                return "";
            }
        }
        public static Image BacaGambar(string imageKtp)
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            ConfigurationSectionGroup userSetting = myConf.SectionGroups["userSetting"];

            var settingSection = userSetting.Sections["ISA_MiniTrojan.DbSettings"] as ClientSettingsSection;
            string path = settingSection.Settings.Get("photo_id_path").Value.ValueXml?.InnerText;
            try
            {
                Image image_Ktp = Image.FromFile(path + "\\" + imageKtp);
                return image_Ktp;
            }
            catch
            {
                return null;
            }
        }
        public static void TambahGambar(User u, Image image)
        {
            u.id = GenerateIdUser();

            using(TransactionScope transcope = new TransactionScope())
            {
                try
                {
                    Koneksi k = new Koneksi();
                    u.Foto_ktp = User.SimpanGambar(u, image);
                    string sql = "insert into users " +
                                 "values('" + u.id + "','" + u.email + "','" + u.username + "','" + u.password + "','" + u.nama + "','" + u.saldo + "','" + u.role + "','" + u.sisa_percobaan_login + "','" + u.foto_ktp + "')";
                    Koneksi.JalankanPerintahDML(sql, k);
                    transcope.Complete();
                }
                catch(Exception ex)
                {
                    transcope.Dispose();
                    throw new Exception(ex.Message);
                }
            }
        }
        public static List<User> BacaDataStaff(string filter = "", string nilai = "")
        {
            string sql;
            if (filter == "")
            {
                sql = "select * from users where role = 'Staff'";
            }
            else
            {
                sql = "select * from users" +
                      " where " + filter + " like '%'" + nilai + "%' and role = 'Staff'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<User> listUser = new List<User>();
            while (hasil.Read() == true)
            {
                User user = new User();
                user.Id = int.Parse(hasil.GetValue(0).ToString());
                user.email = hasil.GetValue(1).ToString();
                user.username = hasil.GetValue(2).ToString();
                user.nama = hasil.GetValue(4).ToString();
                user.saldo = hasil.GetValue(5).ToString();
                user.Role = hasil.GetValue(6).ToString();
                user.Sisa_percobaan_login = hasil.GetInt16(7);

                listUser.Add(user);
            }
            return listUser;
        }
        public static bool HapusData(User u)
        {
            string sql = "DELETE FROM users WHERE id= '" + u.Id + "';";

            int jumlahDiubah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDiubah == 0)
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