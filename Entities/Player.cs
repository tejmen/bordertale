using bordertale.Map;

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
        public void SetJob()
        {
            this.hp = this.job.max;
            this.max = this.job.max;
            this.heal = this.job.heal;
        }
        public string name;
        public Job job;
        public int heal;
        public Location location;
        // @todo Add Effects Class
        // @todo Add Armour Class
        // @todo Add Shield Class
        public bool dead;
        // @todo Add Item Class
        // @todo Add Weapons Class
        // @todo Add Missions Class
    }
}
