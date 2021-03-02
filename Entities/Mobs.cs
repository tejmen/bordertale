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
    }
    public class Mobs
    {
        public Mob GreenSlime = new Mob(PrintUtils.GetHashReturn(42)
                                               + "\n"
                                               + PrintUtils.CenterPadHashReturn("A Green Slime appeared out of the dark.", 42)
                                               + "\n"
                                               + PrintUtils.GetHashReturn(42),

                                               PrintUtils.GetHashReturn(32)
                                               + "\n"
                                               + PrintUtils.CenterPadHashReturn("The Green Slime attacked you.", 32)
                                               + "\n"
                                               + PrintUtils.GetHashReturn(32),

                                               PrintUtils.GetHashReturn(44)
                                               + "\n"
                                               + PrintUtils.CenterPadHashReturn("You are dying slowly, incased in slime.", 44)
                                               + "\n"
                                               + PrintUtils.GetHashReturn(44),

                                               PrintUtils.GetHashReturn(36)
                                               + "\n"
                                               + PrintUtils.CenterPadHashReturn("You have defeated a green slime.", 36)
                                               + "\n"
                                               + PrintUtils.CenterPadHashReturn("You have gained 100 XP.", 36)
                                               + "\n"
                                               + PrintUtils.CenterPadHashReturn("You have gained 10 money.", 36)
                                               + "\n"
                                               + PrintUtils.GetHashReturn(36),
                                               300, 40, 100, 10);
        public Mob Zombie = new Mob(PrintUtils.GetHashReturn(37)
                                       + "\n"
                                       + PrintUtils.CenterPadHashReturn("A Zombie appeared out of the dark.", 37)
                                       + "\n"
                                       + PrintUtils.GetHashReturn(37),

                                       PrintUtils.GetHashReturn(28)
                                       + "\n"
                                       + PrintUtils.CenterPadHashReturn("The Zombie attacked you.", 28)
                                       + "\n"
                                       + PrintUtils.GetHashReturn(28),

                                       PrintUtils.GetHashReturn(74)
                                       + "\n"
                                       + PrintUtils.CenterPadHashReturn("You are now a zombie as the zombie who just killed you is now a human.", 74)
                                       + "\n"
                                       + PrintUtils.GetHashReturn(74),

                                       PrintUtils.GetHashReturn(36)
                                       + "\n"
                                       + PrintUtils.CenterPadHashReturn("You have defeated a green slime.", 36)
                                       + "\n"
                                       + PrintUtils.CenterPadHashReturn("You have gained 500 XP.", 36)
                                       + "\n"
                                       + PrintUtils.CenterPadHashReturn("You have gained 25 money.", 36)
                                       + "\n"
                                       + PrintUtils.GetHashReturn(36),
                                       500, 60, 500, 25);
        public Mob Skeleton = new Mob(PrintUtils.GetHashReturn(39)
                                       + "\n"
                                       + PrintUtils.CenterPadHashReturn("A Skeleton appeared out of the dark.", 39)
                                       + "\n"
                                       + PrintUtils.GetHashReturn(39),

                                       PrintUtils.GetHashReturn(30)
                                       + "\n"
                                       + PrintUtils.CenterPadHashReturn("The skeleton attacked you.", 30)
                                       + "\n"
                                       + PrintUtils.GetHashReturn(30),

                                       PrintUtils.GetHashReturn(53)
                                       + "\n"
                                       + PrintUtils.CenterPadHashReturn("You are Dead, with a arrow impaled in your heart.", 53)
                                       + "\n"
                                       + PrintUtils.GetHashReturn(53),

                                       PrintUtils.GetHashReturn(36)
                                       + "\n"
                                       + PrintUtils.CenterPadHashReturn("You have defeated a skeleton.", 36)
                                       + "\n"
                                       + PrintUtils.CenterPadHashReturn("You have gained 300 XP.", 36)
                                       + "\n"
                                       + PrintUtils.CenterPadHashReturn("You have gained 25 money.", 36)
                                       + "\n"
                                       + PrintUtils.GetHashReturn(36),
                                       500, 60, 300, 25);
        public Mob Spider = new Mob(PrintUtils.GetHashReturn(39)
                               + "\n"
                               + PrintUtils.CenterPadHashReturn("A Skeleton appeared out of the dark.", 39)
                               + "\n"
                               + PrintUtils.GetHashReturn(39),

                               PrintUtils.GetHashReturn(30)
                               + "\n"
                               + PrintUtils.CenterPadHashReturn("The skeleton attacked you.", 30)
                               + "\n"
                               + PrintUtils.GetHashReturn(30),

                               PrintUtils.GetHashReturn(53)
                               + "\n"
                               + PrintUtils.CenterPadHashReturn("You are Dead, with a arrow impaled in your heart.", 53)
                               + "\n"
                               + PrintUtils.GetHashReturn(53),

                               PrintUtils.GetHashReturn(36)
                               + "\n"
                               + PrintUtils.CenterPadHashReturn("You have defeated a skeleton.", 36)
                               + "\n"
                               + PrintUtils.CenterPadHashReturn("You have gained 300 XP.", 36)
                               + "\n"
                               + PrintUtils.CenterPadHashReturn("You have gained 25 money.", 36)
                               + "\n"
                               + PrintUtils.GetHashReturn(36),
                               600, 10, 500, 40); //@todo Add effects to spider
    }
}
