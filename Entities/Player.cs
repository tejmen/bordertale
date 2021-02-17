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
            location = Map.b2;
        }
        public void SetJob()
        {
            this.hp = this.job.max;
            this.max = this.job.max;
            this.heal = this.job.heal;
        }
        public void PrintLocation()
        {
            System.Console.WriteLine("");
            int length = 4 + this.location.description.Length;
            PrintUtils.GetHash(length);
            PrintUtils.LeftPadHash(this.location.zoneName, length);
            PrintUtils.LeftPadHash(this.location.description, length);
            PrintUtils.GetHash(length);
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
