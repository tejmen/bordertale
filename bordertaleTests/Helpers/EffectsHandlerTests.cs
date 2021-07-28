using NUnit.Framework;
using bordertale.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bordertale.Entities;

namespace bordertale.Helpers.Tests
{
    [TestFixture()]
    public class EffectsHandlerTests
    {
        [TestCase(Effects.Poison)]
        [TestCase(Effects.Burning)]
        [TestCase(Effects.Frozen)]
        public void HandleEffectTest(Effects effectToUse)
        {
            Player player = new();
            player.HpChange(200);
            player.effects.Add(effectToUse);
            foreach (Effects effect in player.effects)
            {
                EffectsHandler.HandleEffect(player, effect);
            }
            switch (effectToUse)
            {
                case Effects.None:
                    break;
                case Effects.Poison:
                    Assert.That(player.hp, Is.EqualTo(200 - 5));
                    break;
                case Effects.Burning:
                    Assert.That(player.hp, Is.EqualTo(200 - 10));
                    break;
                case Effects.Frozen:
                    Assert.That(player.hp, Is.EqualTo(200 - 7));
                    break;
                case Effects.Paralyzed:
                    break;
            }
        }
    }
}