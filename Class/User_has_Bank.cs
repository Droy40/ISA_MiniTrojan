using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class User_has_Bank
    {
        private Bank bank;
        private User user;
        private int saldo;

        public User_has_Bank(Bank bank, User user, int saldo)
        {
            Bank = bank;
            User = user;
            Saldo = saldo;
        }

        public Bank Bank { get => bank; set => bank = value; }
        public User User { get => user; set => user = value; }
        public int Saldo { get => saldo; set => saldo = value; }
    }
}
