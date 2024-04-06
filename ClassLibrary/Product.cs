﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ClassLibrary
{
    public class Product
    {
        private string id;
        private string name;
        private string description;
        private double price;
        private int stock;
        private string photo_path;


        public Product(string id, string name, string description, double price, int stock, string photo_path)
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
            this.Id = "";
            this.Name = "";
            this.Description = "";
            this.Price = 0;
            this.Stock = 0;
            this.Photo_path = "";
        }
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Photo_path { get => photo_path; set => photo_path = value; }

        private static string GenerateIdProduct()
        {
            string sql = "select max(id) from products";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if(hasil.Read() == true)
            {
                return hasil.GetValue(0).ToString() +1;
            }
            return "";

        }

        public static bool TambahData(Product p)
        {
            p.Id = GenerateIdProduct();
            string sql = "insert into products(id,name,description,price,stock,photo_path) " +
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
                product.Id = hasil.GetValue(0).ToString();
                product.Name = hasil.GetValue(1).ToString();
                product.Description = hasil.GetValue(2).ToString();
                product.Price = double.Parse(hasil.GetValue(3).ToString());
                product.Stock = int.Parse(hasil.GetValue(4).ToString());
                product.Photo_path = hasil.GetValue(5).ToString();
                listProduct.Add(product);
            }
            return listProduct;
        }
    }
}