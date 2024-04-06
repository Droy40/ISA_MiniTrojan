using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Buy
    {
        private User user;
        private Item item;
        private DateTime purchasingDate;
        private int totalItem;
        private int totalPrice;

        public Buy(User user, Item item, DateTime purchasingDate, int totalItem, int totalPrice)
        {
            User = user;
            Item = item;
            PurchasingDate = purchasingDate;
            TotalItem = totalItem;
            TotalPrice = totalPrice;
        }

        public User User { get => user; set => user = value; }
        public Item Item { get => item; set => item = value; }
        public DateTime PurchasingDate { get => purchasingDate; set => purchasingDate = value; }
        public int TotalItem { get => totalItem; set => totalItem = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
