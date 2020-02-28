using Microsoft.VisualStudio.TestTools.UnitTesting;
using Addition;
using System;
using System.Collections.Generic;
using System.Text;

namespace Addition.Tests
{
    [TestClass()]
    public class AddingTests
    {
        Adding Addition = new Adding();
        private readonly int aInt = 1;
        private readonly int bInt = 2;

        [TestMethod()]
        public void SumTest()
        {
            Addition.Sum(aInt, bInt);
            Assert.AreEqual(3, Adding.Result);
        }

        /* [TestMethod()]
         public void SumDoubleTest()
         {
             Addition.Sum(aDouble, bDouble);
             Assert.AreEqual(4, Adding.Result);
         }*/

        [TestMethod()]
        public void SumTest1()
        {
            decimal[] arrayList = { 1.1M, 2.1M, 3.1M };
            Addition.Sum(arrayList);
            Assert.AreEqual(6.3M, Adding.Result);
        }
    }
}