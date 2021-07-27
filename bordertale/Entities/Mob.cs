using System;
namespace bordertale.Entities
{
    public class Mob : Entity
    {
        public string appear;
        public string attack;
        public string kill;
        public string defeat;

        public Mob(string appear, string attack, string kill, string defeat, int max, int ap, int xp, int money) //@todo Add effects to Mob Constructor
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
        }

        internal void Damage(int amount)
        {
            this.hp -= amount;
        }
    }
}
