using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClassLibrary
{
    public class Transaksi
    {
        private int id;
        private DateTime date;
        private double total;
        private User user;
        private List<DetailTransaksi> detailTransaksiList;

        public Transaksi(int id, DateTime date, double total, User user)
        {
            Id = id;
            Date = date;
            Total = total;
            User = user;
            DetailTransaksiList = new List<DetailTransaksi>();
        }
        public Transaksi()
        {
            Id = 0;
            Date = new DateTime();
            Total = 0;
            User = null;
            DetailTransaksiList = new List<DetailTransaksi>();
        }
        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public double Total { get => total; set => total = value; }
        public User User { get => user; set => user = value; }
        public List<DetailTransaksi> DetailTransaksiList { get; set; }

        private static int GenerateIdTransaksi()
        {
            string sql = "select max(id) from transaksi";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if (hasil.Read() == true)
            {
                return int.Parse(hasil.GetValue(0).ToString()) + 1;
            }
            return 1;
        }
        public static bool TambahData(Transaksi t)
        {
            t.Id = GenerateIdTransaksi();
            string sql = "insert into transaksi(id, date, total, users_id) " +
                         "values ('" + t.Id + "','" + t.Date + "','" + t.Total + "', '" + t.User + "')";
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

        public static List<Transaksi> BacaData(string filter = "", string nilai = "")
        {
            string sql;
            if(filter == "")
            {
                sql = "select * from Transaksi";
            }
            else
            {
                sql = "select * from Transaksi" +
                      " where " + filter + " like '%'" + nilai + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Transaksi> listTransaksi = new List<Transaksi>();
            while(hasil.Read() == true)
            {
                Transaksi t = new Transaksi();
                t.Id = hasil.GetInt32(0);
                t.Date = DateTime.Parse(hasil.GetValue(1).ToString());
                t.Total = double.Parse(hasil.GetValue(2) .ToString());
                
                User tampung = new User();
                tampung.Id = int.Parse(hasil.GetValue(3).ToString());
                tampung.email = hasil.GetValue(4).ToString();
                tampung.username = hasil.GetValue(5).ToString();
                tampung.password = "";
                tampung.nama = hasil.GetValue(6).ToString();
                tampung.saldo = hasil.GetValue(7).ToString();
                tampung.role = hasil.GetValue(8).ToString();
                tampung.Sisa_percobaan_login = hasil.GetInt32(9);
                t.User = tampung;
                listTransaksi.Add(t); 
            }
            return listTransaksi;
        }
    }
}
