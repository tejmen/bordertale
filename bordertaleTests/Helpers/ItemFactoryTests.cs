using NUnit.Framework;
using bordertale.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bordertale.Articles;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace bordertale.Helpers.Tests
{
    [TestFixture()]
    public class ItemFactoryTests
    {
        [TestCase("sword")]
        [TestCase("knife")]
        public void CreateWeaponTest(string name)
        {
            Weapon weapon = (Weapon)ItemFactory.CreateItem(name);
            Assert.That(weapon.title, Is.EqualTo(name));
        }
        [TestCase("shield")]
        public void CreateShieldTest(string name)
        {
            Shield shield = (Shield)ItemFactory.CreateItem(name);
            Assert.That(shield.title, Is.EqualTo(name));
        }
        [TestCase("chestplate")]
        [TestCase("helmet")]
        [TestCase("leggings")]
        [TestCase("boots")]
        public void CreateArmourTest(string name)
        {
            Armour armour = (Armour)ItemFactory.CreateItem(name);
            Assert.That(armour.title, Is.EqualTo(name));
        }
    }
}