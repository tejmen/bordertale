using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bordertale.Articles
{
    public class Armour : DegradableItem
    {
        public Armour(string title, string name, int price, int durability, int dp) : base(title, name, price, durability)
        {
            this.dp = dp;
        }
        public int dp;
    }
}
