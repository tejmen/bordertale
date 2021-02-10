using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bordertale.Entities
{
    public class Entity
    {
        public int hp;
        public int money;
        public int ap;
        protected int xp;
        protected int max;
        public void HpChange(int amount)
        {
            hp += amount;
        }
        public void HpReset()
        {
            hp = max;
        }
    }
}
