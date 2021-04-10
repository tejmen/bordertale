using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bordertale.Articles
{
    public class DegradableItem : Item
    {
        public int durability;

        public void Degrade(int amount = 1)
        {
            this.durability -= amount;
        }
    }
}
