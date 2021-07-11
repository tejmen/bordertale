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
            Player player = new Player();
            Armour helmet = new Armour("helmet", "Iron Helmet", 20, 100, 20);
            player.Acquire(helmet);
            player.Equip(helmet);
            Assert.IsFalse(player.inventory.Any());
        }
    }
}