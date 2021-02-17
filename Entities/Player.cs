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
        // TODO Add Effects Class
        // TODO Add Armour Class
        // TODO Add Shield Class
        public bool dead;
        // TODO Add Item Class
        // Add Weapons Class
        // TODO Add Missions Class
    }
}
