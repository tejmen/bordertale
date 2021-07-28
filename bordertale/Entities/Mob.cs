using System;
using System.Collections.Generic;
namespace bordertale.Entities
{
    public class Mob : Entity
    {
        public string appear;
        public string attack;
        public string kill;
        public string defeat;

        public List<Effects> effects;

        public Mob(string appear, string attack, string kill, string defeat, int max, int ap, int xp, int money, List<Effects> effects = null)
        {
            this.appear = appear;
            this.attack = attack;
            this.defeat = defeat;
            this.kill = kill;
            this.hp = max;
            this.max = max;
            this.ap = ap;
            this.xp = xp;
            this.money = money;
            this.effects = effects;
        }
    }
}
