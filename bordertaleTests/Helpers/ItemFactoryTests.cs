using Microsoft.VisualStudio.TestTools.UnitTesting;
using bordertale.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bordertale.Articles;

namespace bordertale.Helpers.Tests
{
    [TestClass()]
    public class ItemFactoryTests
    {
        [TestMethod()]
        public void CreateItemTest()
        {
            Weapon sword = (Weapon)ItemFactory.CreateItem("sword");
            Assert.AreEqual(sword.title, "sword");
            Weapon knife = (Weapon)ItemFactory.CreateItem("knife");
            Assert.AreEqual(knife.title, "knife");
            Shield shield = (Shield)ItemFactory.CreateItem("shield");
            Assert.AreEqual(shield.title, "shield");
            Armour chestplate = (Armour)ItemFactory.CreateItem("chestplate");
            Assert.AreEqual(chestplate.title, "chestplate");
            Armour helmet = (Armour)ItemFactory.CreateItem("helmet");
            Assert.AreEqual(helmet.title, "helmet");
        }
    }
}