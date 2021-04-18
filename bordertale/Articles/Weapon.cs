using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bordertale.Articles
{
    public class Weapon : DegradableItem
    {
        public Weapon(string title, string name, int price, int durability, int ap) : base(title, name, price, durability)
        {
            this.ap = ap;
        }
        public int ap;
    }
}
