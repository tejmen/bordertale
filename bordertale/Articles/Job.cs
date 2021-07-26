namespace bordertale.Articles
{
    public class Job
    {
        public int max;
        public int hp;
        public int ap;
        public int heal;
        public string name;
        public Weapon weapon;
        public Job(string name, int max, int ap, Weapon weapon, int heal = 0)
        {
            this.max = max;
            this.ap = ap;
            this.heal = heal;
            this.name = name;
            this.weapon = weapon;
        }
    }
}
