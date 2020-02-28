using Microsoft.VisualStudio.TestTools.UnitTesting;
using Division;
using System;
using System.Collections.Generic;
using System.Text;

namespace Division.Tests
{
    [TestClass()]
    public class DividingTests
    {

        private readonly decimal aDecimal = 1.5M;
        private readonly decimal bDecimal = 2.5M;
        Dividing Division = new Dividing();

        [TestMethod()]
        public void QuotientTest()
        {
            Division.Quotient(aDecimal, bDecimal);
            Assert.AreEqual(0.6M, Dividing.Result);
        }
    }
}