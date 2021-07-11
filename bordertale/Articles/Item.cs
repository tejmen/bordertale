using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bordertale.Articles
{
    public class Item
    {
        public Item(string title, string name, int price)
        {
            this.title = title;
            this.name = name;
            this.price = price;
        }
        public string title;
        public string name;
        public int price;
    }
}
