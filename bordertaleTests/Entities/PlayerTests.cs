using bordertale.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace bordertale.Entities.Tests
{
    [TestFixture]
    public class PlayerTests
    {
        [Test]
        public void SetJobTest()
        {
            // Arrange
            Player player = new Player();
            Job job = new Job("Test", 200, 200, 200);
            // Act
            player.job = job;
            player.SetJob();
            // Assert
            Assert.That(player.hp, Is.EqualTo(200));
            // Could also Use
            Assert.That(player.ap == 200);
            // Or
            Assert.That(player.heal.Equals(200));
            // Or Assert.Equals(player.heal, 200);

        }
    }
}