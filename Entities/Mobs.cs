using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bordertale.Entities
{
    public class Mob : Entity
    {
        public string appear;
        public string attack;
        public string kill;
        public string defeat;

        public Mob(string appear, string attack, string kill, string defeat)
        {
            this.appear = appear;
            this.attack = attack;
            this.defeat = defeat;
            this.kill = kill;
        }
    }
    public class Mobs
    {
        //@todo Add rest of Text
        //@body Add the rest of the mobs, complete with their respective strings.
        public static Mob GreenSlime = new Mob(PrintUtils.GetHashReturn(42) + "\n" + PrintUtils.CenterPadHashReturn("A Green Slime appeared out of the dark", 42) + "\n" + PrintUtils.GetHashReturn(42), null, null, null);
    }
}
