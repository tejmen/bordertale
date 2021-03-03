using Microsoft.VisualStudio.TestTools.UnitTesting;
using bordertale.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bordertale.Entities.Tests
{
    [TestClass()]
    public class PlayerTests
    {
        [TestMethod()]
        public void SetJobTest()
        {
            Player player = new Player();
            Job job = new Job("Test", 200, 200, 200);
            player.job = job;
            player.SetJob();
            Assert.AreNotEqual(0, player.hp);
            Assert.AreNotEqual(0, player.ap);
            Assert.AreNotEqual(0, player.heal);
        }
    }
}