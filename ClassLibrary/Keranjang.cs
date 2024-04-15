using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClassLibrary
{
    public class Keranjang
    {
        private User user;
        private Product product;
        private int jumlah;

        public Keranjang()
        {
            User = new User();
            Product = new Product();
            Jumlah = 0;
        }
        public Keranjang(User user, Product product, int jumlah)
        {
            User = user;
            Product = product;
            Jumlah = jumlah;
        }

        public User User { get => user; set => user = value; }
        public Product Product { get => product; set => product = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }

        public static List<Keranjang> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "select u.id, p.product, k.jumlah from keranjang as k" +
                      " inner join users as u on k.users_id = u.id" +
                      " inner join produk as p on k.produk_id = p.id";
            }
            else
            {
                sql = "select u.id, p.product, k.jumlah from keranjang as k" +
                      " inner join users as u on k.users_id = u.id" +
                      " inner join produk as p on k.produk_id = p.id" +
                      " where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Keranjang> listKeranjang = new List<Keranjang>();
            while (hasil.Read() == true)
            {
                User u = new User();
                u.Id = int.Parse(hasil.GetValue(0).ToString());
                Product p = new Product();
                p.Id = int.Parse(hasil.GetValue(1).ToString());
                Keranjang k = new Keranjang();
                k.User = u;
                k.Product = p;
                k.Jumlah = int.Parse(hasil.GetValue(2).ToString());
                listKeranjang.Add(k);
            }
            return listKeranjang;
        }
        public static bool TambahData(Keranjang k)
        {
            string sql = "insert into keranjang " +
                         "values('" + k.User.Id + "','" + k.Product.Id + "','" + k.Jumlah + "')";

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
        public static bool UpdateData(Keranjang k)
        {
            string sql = "update keranjang " +
                         "set users_id ='" + k.User.Id + "', produk ='" + k.Product.Id + "', jumlah ='" + k.Jumlah + "'" +
                         "where users_id ='" + k.User.Id + "'";
            int jumlahDataBerubah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDataBerubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool HapusData(Keranjang k)
        {
            string sql = "delete from keranjang " +
                         "where users_id ='" + k.User.Id + "'";
            int jumlahDataBerubah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDataBerubah == 0)
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
