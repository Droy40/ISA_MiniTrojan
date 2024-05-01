using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Topup
    {
        private int id;
        private User user;
        private DateTime topup_date;
        private double nominal;
        private string status;
        private User staff;

        public Topup(int id, User user, DateTime topup_date, double nominal, string status, User staff)
        {
            Id = id;
            User = user;
            Topup_date = topup_date;
            Nominal = nominal;
            Status = status;
            Staff = staff;
        }

        public Topup()
        {
            Id = 0;
            User = new User();
            Topup_date = new DateTime();
            Nominal = 0;
            Status = "";
            Staff = new User();
        }

        public int Id { get => id; set => id = value; }
        public User User { get => user; set => user = value; }
        public DateTime Topup_date { get => topup_date; set => topup_date = value; }
        public double Nominal { get => nominal; set => nominal = value; }
        public string Status { get => status; set => status = value; }
        public User Staff { get => staff; set => staff = value; }

        private static int GenerateId()
        {
            string sql = "select max(id) from topups";
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

        public static bool TambahData(Topup topup)
        {
            topup.Id = GenerateId();
            topup.status = "PENDING";
            string sql = "INSERT INTO topups (id, user_id, topup_date, nominal, status) VALUES ('" + topup.Id + "', '" + topup.User.Id + "', 'now()', '" + topup.Nominal + "', '" + topup.Status + "')";

            int jumlahDiubah = Koneksi.JalankanPerintahDML(sql);

            if(jumlahDiubah == 0)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
