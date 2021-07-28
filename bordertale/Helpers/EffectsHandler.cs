using bordertale.Entities;
using System;

namespace bordertale.Helpers
{
    public static class EffectsHandler
    {
        public static void HandleEffect(Entity entity, Effects effects)
        {
            switch (effects)
            {
                case Effects.None:
                    break;
                case Effects.Poison:
                    entity.Damage(5);
                    break;
                case Effects.Burning:
                    entity.Damage(10);
                    break;
                case Effects.Frozen:
                    entity.Damage(7);
                    break;
                case Effects.Paralyzed:
                    throw new NotImplementedException();
            }
        }
    }
}