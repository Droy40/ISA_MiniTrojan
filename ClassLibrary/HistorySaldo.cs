﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClassLibrary
{
    public class HistorySaldo
    {
        private int id;
        private User user;
        private DateTime waktuTransaksi;
        private string nominal;
        private string jenis;
        private Transaksi transaksi;

        public HistorySaldo()
        {
            Id = 0;
            User = new User();
            WaktuTransaksi = new DateTime();
            Nominal = 0;
            Jenis = "";
            Transaksi = new Transaksi();
        }

        public HistorySaldo(int id, User user, DateTime waktuTransaksi, double nominal, string jenis, Transaksi transaksi)
        {
            Id = id;
            User = user;
            WaktuTransaksi = waktuTransaksi;
            Nominal = nominal;
            Jenis = jenis;
            Transaksi = transaksi;
        }

        public int Id { get => id; set => id = value; }
        public User User { get => user; set => user = value; }
        public DateTime WaktuTransaksi { get => waktuTransaksi; set => waktuTransaksi = value; }
        public double Nominal 
        {
            get => double.Parse(AES.Decrypt(nominal, AES.key));
            set => nominal = AES.Encrypt(value.ToString(), AES.key);
        }
        public string Jenis { get => jenis; set => jenis = value; }
        public Transaksi Transaksi { get => transaksi; set => transaksi = value; }

        private static int GenerateIdHistorySaldo()
        {
            string sql = "select max(id) from history_saldo";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if(hasil.Read() == true)
            {
                return hasil.GetInt32(0) + 1;
            }
            return 1 ;

        }

        public static bool TambahData(HistorySaldo hs)
        {
            hs.Id = GenerateIdHistorySaldo();
            string sql = "INSERT INTO `mydb`.`history_saldo` (`id`, `users_id`, `transaction_date`, `nominal`, `jenis`, `transactions_id`)" +
            "VALUES ('"+hs.Id+"', '"+hs.User.Id+"', '"+hs.WaktuTransaksi+"', '"+ hs.nominal+"', '"+ hs.Jenis+"', '"+hs.Transaksi.Id+"');";
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

        public static List<HistorySaldo> BacaData(string filter = "", string nilai = "")
        {
            string sql;
            if (filter == "")
            {
                sql = "select * from History_Saldo";
            }
            else if (filter=="users_id")
            {
                sql = "select * from History_Saldo" +
                      " where " + filter + " = '" + nilai + "'";
            }
            else
            {
                sql = "select * from History_Saldo" +
                      " where " + filter + " like '%'" + nilai + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<HistorySaldo> listHistorySaldo = new List<HistorySaldo>();
            while (hasil.Read() == true)
            {
                HistorySaldo hs = new HistorySaldo();
                hs.Id = int.Parse(hasil.GetValue(0).ToString());

                User tampungUser = new User();
                tampungUser.Id = int.Parse(hasil.GetValue(1).ToString());
                hs.User = tampungUser;

                hs.WaktuTransaksi = DateTime.Parse(hasil.GetValue(2).ToString());
                hs.nominal = hasil.GetValue(3).ToString();
                hs.Jenis = hasil.GetValue(4).ToString();

                Transaksi tampungTransaksi = new Transaksi();
                tampungTransaksi.Id = int.Parse(hasil.GetValue(5).ToString());
                hs.Transaksi = tampungTransaksi;

                listHistorySaldo.Add(hs);
            }
            return listHistorySaldo;
        }
    }
}
