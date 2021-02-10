using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bordertale.Entities
{
    public class Player : Entity
    {
        public Player()
        {
            name = "";
            hp = 0;
            max = 0;
            xp = 0;
            ap = 0;
            job = null;
            heal = 0;
            dead = false;
            money = 0;
        }
        public string name;
        public Job job;
        public int heal;
        // TODO Add Effects Class
        // TODO Add Armour Class
        // TODO Add Shield Class
        // TODO Add Location Class
        public bool dead;
        // TODO Add Item Class
        // Add Weapons Class
        // TODO Add Missions Class
    }
}
