using bordertale.Entities;
using System;
using System.Runtime.CompilerServices;

namespace bordertale.Helpers
{
    public static class MobFactory
    {
        private static Mob spider = new Mob(PrintUtils.GetHashReturn(39)
                              + "\n"
                              + PrintUtils.CenterPadHashReturn("A Spider appeared out of the dark.", 39)
                              + "\n"
                              + PrintUtils.GetHashReturn(39),

                              PrintUtils.GetHashReturn(30)
                              + "\n"
                              + PrintUtils.CenterPadHashReturn("The spider attacked you.", 30)
                              + "\n"
                              + PrintUtils.GetHashReturn(30),

                              PrintUtils.GetHashReturn(53)
                              + "\n"
                              + PrintUtils.CenterPadHashReturn("You are Dead, with a spider biting you to death.", 53)
                              + "\n"
                              + PrintUtils.GetHashReturn(53),

                              PrintUtils.GetHashReturn(36)
                              + "\n"
                              + PrintUtils.CenterPadHashReturn("You have defeated a spider.", 36)
                              + "\n"
                              + PrintUtils.CenterPadHashReturn("You have gained 350 XP.", 36)
                              + "\n"
                              + PrintUtils.CenterPadHashReturn("You have gained 40 money.", 36)
                              + "\n"
                              + PrintUtils.GetHashReturn(36),
                              600, 10, 500, 40, new() {Effects.Poison});
        private static Mob greenS = new Mob(PrintUtils.GetHashReturn(42)
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
                                               300, 40, 100, 10, new() { Effects.Burning });
        private static Mob skeleton = new Mob(PrintUtils.GetHashReturn(39)
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
        private static Mob zombie = new Mob(PrintUtils.GetHashReturn(37)
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
                                       500, 60, 500, 25, new() { Effects.Frozen });
        /// <summary>
        /// Create a mob based on its name
        /// </summary>
        /// <param name="mobName">the name of the mob to create, or random, for a random mob</param>
        /// <returns>A Mob object</returns>
        public static Mob CreateMob(string mobName)
        {
            switch (mobName.ToLower())
            {
                case "greens":
                    return greenS;
                case "zombie":
                    return zombie;
                case "skeleton":
                    return skeleton;
                case "spider":
                    return spider;
                case "random":
                    Mob[] mobs = {greenS, zombie, skeleton, spider};
                    int index = new Random().Next(mobs.Length);
                    return mobs[index];
                default:
                    return null;
            }
        }
    }
}