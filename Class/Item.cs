using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Item
    {
        private string id;
        private string name;
        private string description;
        private string imgItem;
        private int price;

        public Item(string id, string name, string description, string imgItem, int price)
        {
            Id = id;
            Name = name;
            Description = description;
            ImgItem = imgItem;
            Price = price;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string ImgItem { get => imgItem; set => imgItem = value; }
        public int Price { get => price; set => price = value; }
    }
}
