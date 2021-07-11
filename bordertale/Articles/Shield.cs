using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bordertale.Articles
{
    public class Shield : DegradableItem
    {
        public Shield(string title, string name, int price, int durability, int defenceChance) : base(title, name, price, durability)
        {
            this.defenceChance = defenceChance;
        }
        public int defenceChance;

        public bool TryDefend()
        {
            int tryDefenceChance = new Random().Next(0, 100);
            if (tryDefenceChance <= defenceChance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

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
