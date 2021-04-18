using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bordertale.Articles
{
    public class DegradableItem : Item
    {
        public DegradableItem(string title, string name, int price, int durability) : base(title, name, price)
        {
            this.durability = durability;
        }
        public int durability;

        public void Degrade(int amount = 1)
        {
            this.durability -= amount;
        }
    }
}
