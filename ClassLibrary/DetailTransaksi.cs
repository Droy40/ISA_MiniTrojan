﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClassLibrary
{
    public class DetailTransaksi
    {
        private Transaksi transactions;
        private Product product;
        private int quantity;
        private double harga;

        public DetailTransaksi(Transaksi transactions, Product product, int quantity, double harga)
        {
            Transactions = transactions;
            Product = product;
            Quantity = quantity;
            Harga = harga;
        }
        public DetailTransaksi()
        {
            Transactions = null;
            Product = null;
            Quantity = 0;
            Harga = 0;
        }
        public Transaksi Transactions { get => transactions; set => transactions = value; }
        public Product Product { get => product; set => product = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Harga { get => harga; set => harga = value; }

        public static List<DetailTransaksi> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql;
            if(kriteria == "")
            {
                sql = "select t.id, p.id, dt.quantity, dt.harga from detail_transaksi " +
                      "inner join transaksi as t on dt.transaksi_id = t.id " +
                      "inner join produk as p on dt.products_id = p.id";
            }
            else
            {
                sql = "select t.id, p.id, dt.quantity, dt.harga from detail_transaksi " +
                      "inner join transaksi as t on dt.transaksi_id = t.id " +
                      "inner join produk as p on dt.products_id = p.id " +
                      "where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<DetailTransaksi> listDetailTransaksi = new List<DetailTransaksi>();
            while(hasil.Read() == true)
            {
                Transaksi t = new Transaksi();
                t.Id = int.Parse(hasil.GetValue(0).ToString());
                Product p = new Product();
                p.Id = int.Parse(hasil.GetValue(1).ToString());
                DetailTransaksi dt = new DetailTransaksi();
                dt.Transactions = t;
                dt.Product = p;
                dt.Quantity = int.Parse(hasil.GetValue(2).ToString());
                dt.Harga = int.Parse(hasil.GetValue(3).ToString());
                listDetailTransaksi.Add(dt);
            }
            return listDetailTransaksi;
        }
        public static bool TambahData(DetailTransaksi dt)
        {
            string sql = "insert into detail_transaksi " +
                         "values ('" + dt.Transactions.Id + "','" + dt.Product.Id + "','" + dt.Quantity + "','" + dt.Harga + "')";
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
