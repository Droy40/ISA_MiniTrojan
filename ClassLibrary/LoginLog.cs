using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClassLibrary
{
    public class LoginLog
    {
        private int id;
        private User user;
        private DateTime date;
        private bool status;

        public LoginLog(int id, User user, DateTime date, bool status)
        {
            Id = 0;
            User = user;
            Date = date;
            Status = status;
        }
        public LoginLog()
        {
            Id = 0
            User = new User();
            Date = new DateTime();
            Status = false; 
        }

        public int Id { get => id; set => id = value; }
        public User User { get => user; set => user = value; }
        public DateTime Date { get => date; set => date = value; }
        public bool Status { get => status; set => status = value; }


        public static bool TambahData(LoginLog l)
        {
            int status = (l.status) ? 1 : 0;
            string sql = "insert into login_log(user_id, date, status) " +
                         "values('" + l.UserLog.Id + "',now(),'" + l.Status + "')";

            int jumlahDataBerubah = Koneksi.JalankanPerintahDML(sql);
            if(jumlahDataBerubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static List<LoginLog> BacaData(string kriteria = "", string nilaiKriteria = "")
        {
            string sql;
            if(kriteria == "")
            {
                sql = "select u.id, l.date, l.status from login_log as l " +
                      " inner join users as u on l.users_id = u.id";
            }
            else
            {
                sql = "select u.id, l.date, l.status from login_log as l " +
                      " inner join users as u on l.users_id = u.id" +
                      " where " + kriteria + " = '" + nilaiKriteria + "'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<LoginLog> listLoginLog = new List<LoginLog>();
            while(hasil.Read() == true)
            {
                User u = new User();
                u.Id = int.Parse(hasil.GetValue(0).ToString());
                LoginLog l = new LoginLog();
                l.UserLog = u;
                l.Date = DateTime.Parse(hasil.GetValue(1).ToString());
                l.Status = Boolean.Parse(hasil.GetValue(2).ToString());
                listLoginLog.Add(l);
            }
            return listLoginLog;
        }

        public static int CekPercobaanLogin(int idUser)
        {
            string sql = "select count(*) from (select * from login_log where user_id = '" + idUser + "' order by date desc limit 3) where status = '0'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if (hasil.Read())
            {
                int sisaPercobaan = 3 - hasil.GetInt16(0);
                return sisaPercobaan;
            }

            return 3;
        }
    }
}
