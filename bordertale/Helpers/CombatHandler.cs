using bordertale.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bordertale.Helpers
{
    public static class CombatHandler
    {
        public static void Combat(Mob mob)
        {
            Console.WriteLine(mob.appear);
            while (mob.hp > 0)
            {
                CombatRound(mob);
            }
        }

        private static void CombatRound(Mob mob)
        {
            throw new NotImplementedException();
        }
    }
}
