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
        User userLog;
        private DateTime date;
        private bool status;

        public LoginLog(User userLog, DateTime date, bool status)
        {
            UserLog = userLog;
            Date = date;
            Status = status;
        }
        public LoginLog()
        {
            UserLog = null;
            Date = new DateTime();
            Status = false;        }

        public User UserLog { get => userLog; set => userLog = value; }
        public DateTime Date { get => date; set => date = value; }
        public bool Status { get => status; set => status = value; }

        public static bool TambahData(LoginLog l)
        {
            string sql = "insert into login_log " +
                         "values('" + l.UserLog.Id + "','" + l.Date + "','" + l.Status + "')";

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
    }
}
