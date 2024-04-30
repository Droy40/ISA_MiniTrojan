using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlTypes;
using System.Drawing;

namespace ClassLibrary
{
    public class Product
    {
        private int id;
        private string name;
        private string description;
        private double price;
        private int stock;
        private string photo_path;


        public Product(int id, string name, string description, double price, int stock, string photo_path)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Stock = stock;
            this.Photo_path = photo_path;
        }
        public Product()
        {
            this.Id = 0;
            this.Name = "";
            this.Description = "";
            this.Price = 0;
            this.Stock = 0;
            this.Photo_path = "";
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Photo_path { get => photo_path; set => photo_path = value; }

        private static int GenerateIdProduct()
        {
            string sql = "select max(id) from produk";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if(hasil.Read() == true)
            {
                return hasil.GetInt32(0) +1;
            }
            return 1;

        }

        public static bool TambahData(Product p)
        {
            p.Id = GenerateIdProduct();
            string sql = "insert into produk(id,name,description,price,stock,photo_path) " +
                         "values ('" + p.Id + "','" + p.Name + "','" + p.Description + "','" + p.Price + "','" +
                         p.Stock + "','" + p.Photo_path + "')";
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
        public static bool UbahData(Product p)
        {
            string sql = "UPDATE produk SET id='" + p.Id.ToString() + "', nama='" + p.Name + "', " +
                                               "deskripsi= '" + p.Description + "', harga='" + p.Price.ToString() + "', stock='" + p.Stock.ToString() + "', " +
                                               "photo_path= '" + p.Photo_path + "'" +
                         "WHERE id='" + p.Id.ToString() + "';";
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
        public static bool HapusData(Product p)
        {
            string sql = "DELETE FROM products" +
                         " where id='" + p.Id + "';";
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
        public static List<Product> BacaData(string filter = "", string nilai = "")
        {
            string sql;
            if(filter == "")
            {
                sql = "select * from products";
            }
            else
            {
                sql = "select * from products" +
                      " where " + filter + " like '%'" + nilai + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Product> listProduct = new List<Product>();
            while(hasil.Read() == true)
            {
                Product product = new Product();
                product.Id = int.Parse(hasil.GetValue(0).ToString());
                product.Name = hasil.GetValue(1).ToString();
                product.Description = hasil.GetValue(2).ToString();
                product.Price = double.Parse(hasil.GetValue(3).ToString());
                product.Stock = int.Parse(hasil.GetValue(4).ToString());
                product.Photo_path = hasil.GetValue(5).ToString();
                listProduct.Add(product);
            }
            return listProduct;
        }

        public static string SimpanGambar(Product product, Image image )
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            ConfigurationSectionGroup userSettings = myConf.SectionGroups["userSettings"];

            var settingSection = userSettings.Sections["ProjectDatabase.db"] as ClientSettingsSection;
            string path = settingSection.Settings.Get("cover_image").Value.ValueXml.InnerText;

            if (image != null)
            {
                image.Save(path + "\\film_" + f.Id);
                return "film_" + f.Id;

            }
            else
            {
                return "";
            }
        }
    }
}
