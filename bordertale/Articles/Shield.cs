using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bordertale.Articles
{
    public class Shield : DegradableItem
    {
        public int dp;
        public int defenceChance;

        public new void Degrade(int amount = 1)
        {
            int chance = new Random().Next(0, 100);
            if (chance >= 82)
            {
                this.durability = 0;
            }
            else
            {
                this.durability -= amount;
            }
        }
    }
}
