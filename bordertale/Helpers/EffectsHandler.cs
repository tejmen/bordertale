using bordertale.Entities;
using System;

namespace bordertale.Helpers
{
    public static class EffectsHandler
    {
        public static void HandleEffect(Entity entity, Effects effect)
        {
            switch (effect)
            {
                case Effects.None:
                    break;
                case Effects.Poison:
                    if (entity is Player)
                    {
                        PrintUtils.CenterBoxHash("You are Poisoned, and lose 5 health", "You are Poisoned, and lose 5 health".Length + 5, ConsoleColor.Magenta);
                    }
                    entity.Damage(5);
                    break;
                case Effects.Burning:
                    if (entity is Player)
                    {
                        PrintUtils.CenterBoxHash("You are burned, and lose 10 health", "You are burned, and lose 10 health".Length + 5, ConsoleColor.DarkYellow);
                    }
                    entity.Damage(10);
                    break;
                case Effects.Frozen:
                    if (entity is Player)
                    {
                        PrintUtils.CenterBoxHash("You are frozen, and lose 7 health", "You are frozen, and lose 7 health".Length + 5, ConsoleColor.DarkCyan);
                    }
                    entity.Damage(7);
                    break;
                case Effects.Paralyzed:
                    // TODO: Finish Paralyzed Effect
                    throw new NotImplementedException();
            }
        }
    }
}