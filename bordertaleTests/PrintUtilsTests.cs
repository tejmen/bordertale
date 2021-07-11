using NUnit.Framework;
using bordertale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace bordertale.Tests
{
    [TestFixture]
    public class PrintUtilsTests
    {
        [Test]
        public void CenterPadHashTest_WithEvenSpacing()
        {
            // Arrange
            var input = "Tests";
            var expected = "#  Tests  #";
            var expectedConsole = String.Format("{0}{1}", "#  Tests  #", Environment.NewLine);
            var length = 11;
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            PrintUtils.CenterPadHash(input, length);
            var output = PrintUtils.CenterPadHashReturn(input, length);

            // Assert
            Assert.That(consoleOutput.ToString(), Is.EqualTo(expectedConsole));
            Assert.That(output, Is.EqualTo(expected));
        }

        [TestCase(14)]
        [TestCase(2)]
        [TestCase(214)]
        public void GetHashTest(int length)
        {
            // Arrange
            var expected = String.Format("{0}{1}", new String('#', length), Environment.NewLine);
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            PrintUtils.GetHash(length);
        }
    }
}