using System;
using NUnit.Framework;

namespace UnitTest {
    [TestFixture]
    public class UnitTestMain {
        [Test]
        public void ShowAvailableTickets_ifOnSaleIsNull_ReturnZero() {
            LearnCsharp.ticketsOnSale = null;
            int availableTickets = LearnCsharp.CalculateTickets();
            Assert.AreEqual(availableTickets, 0);
        }
        
        [Test]
        public void ShowAvailableTickets_ifOnSaleIsInt_ReturnSameInt() {
            LearnCsharp.ticketsOnSale = 10;
            int availableTickets = LearnCsharp.CalculateTickets();
            Assert.AreEqual(availableTickets, 10);
        }

        [Test]
        public void ShowAvailableTickets_ifOnSaleIsBelowZero_ReturnZero() {
            LearnCsharp.ticketsOnSale = -10;
            int availableTickets = LearnCsharp.CalculateTickets();
            Assert.AreEqual(availableTickets, 0);
        }

        [Test]
        public void NullCheck_ifIsNotNull_ReturnSomeInt() {
            LearnCsharp.ticketsOnSale = 10;
            int availableTickets = LearnCsharp.NullChecks();
            Assert.AreEqual(availableTickets, 10);
        }
    }
}
