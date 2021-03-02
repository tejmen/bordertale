namespace bordertale.Entities
{
    public class Entity
    {
        public int hp;
        public int money;
        public int ap;
        public int xp;
        protected int max;
        public void HpChange(int amount)
        {
            this.hp += amount;
        }
        public void HpReset()
        {
            this.hp = max;
        }
    }
}
