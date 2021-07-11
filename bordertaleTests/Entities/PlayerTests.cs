using NUnit.Framework;
using bordertale.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bordertale.Articles;

namespace bordertale.Entities.Tests
{
    [TestFixture()]
    public class PlayerTests
    {
        [Test()]
        public void EquipArmourTest()
        {
            Player player = new();
            Armour helmet = new("helmet", "Iron Helmet", 20, 100, 20);
            player.Acquire(helmet);
            player.Equip(helmet);
            Assert.IsFalse(player.inventory.Any());
        }

        [Test()]
        public void ItemEquipTest()
        {
            Player player = new();
            Weapon weapon = new("weapon", "Test Weapon", 200, 200, 200);
            player.Acquire(weapon);
            player.Equip(weapon);
            Assert.IsFalse(player.inventory.Any());
        }
    }
}