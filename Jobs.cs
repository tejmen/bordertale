using bordertale.Entities;

namespace bordertale
{
    public class Job
    {
        public int max;
        public int hp;
        public int ap;
        public int heal;
        public string name;
        // TODO Add Weapons Class
        public Job(string name, int max, int ap, int heal = 0)
        {
            this.max = max;
            this.ap = ap;
            this.heal = heal;
            this.name = name;
        }
    }
}
