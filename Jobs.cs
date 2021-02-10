using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bordertale
{
    public class Job
    {
        public int max;
        public int hp;
        public int ap;
        public int heal;
        // TODO Add Weapons Class
        public Job(int max, int ap, int heal = 0)
        {
            this.max = max;
            this.ap = ap;
            this.heal = heal;
        }
    }
    public class Jobs
    {
        public Job fighter = new Job(120, 40);
        public Job healer = new Job(200, 20, 40);
        public Job wizard = new Job(300, 20, 20);
    }
}
