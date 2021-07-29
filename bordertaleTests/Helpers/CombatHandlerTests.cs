using NUnit.Framework;
using bordertale.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bordertale.Entities;
using bordertale.Articles;

namespace bordertale.Helpers.Tests
{
    [TestFixture()]
    public class CombatHandlerTests
    {
        [Test()]
        public void CombatTest()
        {
            Player player = new();
            player.name = "Developer";
            player.job = new Articles.Job("Fighter", 120, 40, (Weapon)ItemFactory.CreateItem("sword"));
            player.SetJob();
            Mob mob = MobFactory.CreateMob("greens");
            CombatHandler.Combat(mob, player, true);
            Assert.That(mob.hp, Is.EqualTo(0));
            Assert.That(player.hp, !Is.EqualTo(player.job.max));
        }
    }
}