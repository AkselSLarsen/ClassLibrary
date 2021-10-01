using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test {
    [TestClass]
    public class FootballPlayerTests {
        [TestMethod]
        public void PositiveTest() {
            FootballPlayer fbp = new FootballPlayer(1, "Name", 1.02f, 42);

            Assert.IsNotNull(fbp);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TooShortNameTest() {
            FootballPlayer fbp = new FootballPlayer(1, "Nam", 1.02f, 42);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PriceNegativeTest() {
            FootballPlayer fbp = new FootballPlayer(1, "Name", -1.02f, 42);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShirtNumberZeroTest() {
            FootballPlayer fbp = new FootballPlayer(1, "Name", 1.02f, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShirtNumberMaxTest() {
            FootballPlayer fbp = new FootballPlayer(1, "Name", 1.02f, int.MaxValue);
        }
    }
}
