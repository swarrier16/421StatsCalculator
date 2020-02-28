using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        private basicCalculator Calculator = new basicCalculator(); //private property for the test class called calculator
        private readonly int aInt = 1;
        private readonly int bInt = 2;
        private readonly double aDouble = 1.5;
        private readonly double bDouble = 2.5;
        private readonly decimal aDecimal = 1.5M;
        private readonly decimal bDecimal = 2.5M;

        [TestInitialize]
        public void Setup()
        {

        }

        [TestMethod()]
        public void AddIntegerTest()
        {
            Calculator.Sum(aInt, bInt);
            Assert.AreEqual(3, basicCalculator.Result);
        }
        [TestMethod()]
        public void AddDoubleTest()
        {
            Calculator.Sum(aDecimal, bDecimal);
            Assert.AreEqual(4M, basicCalculator.Result);
        }
        [TestMethod()]
        public void SubtractIntegerTest()
        {
            Calculator.Difference(aInt, bInt);
            Assert.AreEqual(-1, basicCalculator.Result);
        }
        [TestMethod()]
        public void SubtractDoubleTest()
        {
            Calculator.Difference(aDouble, bDouble);
            Assert.AreEqual(-1, basicCalculator.Result);
        }

        [TestMethod()]
        public void MultiplyIntegerTest()
        {
            Calculator.Product(aInt, bInt);
            Assert.AreEqual(2, basicCalculator.Result);
        }
        [TestMethod()]
        public void MultiplyDoubleTest()
        {
            Calculator.Product(aDouble, bDouble);
            Assert.AreEqual(3.75, basicCalculator.Result);
        }
        [TestMethod()]
        public void DivideTest()
        {
            Calculator.Quotient(aDecimal, bDecimal);
            Assert.AreEqual(0.6M, basicCalculator.Result);
        }

        [TestMethod()]
        public void SquareRootTest()
        {
            Calculator.Root(aDouble);
            Assert.AreEqual(1.224744871391589, basicCalculator.Result);
        }

        [TestMethod()]
        public void ExponentTest()
        {
            Calculator.Power(aDouble, bDouble);
            Assert.AreEqual(2.7556759606310752, basicCalculator.Result);
        }

        [TestMethod()]
        public void SumIntTest()
        {
            int[] arrayList = { 1, 2, 3 };
            Calculator.Sum(arrayList);
            Assert.AreEqual(6, basicCalculator.Result);
        }
        [TestMethod()]
        public void SumDecimalTest()
        {
            decimal[] arrayList = { 1.1M, 2.1M, 3.1M };
            Calculator.Sum(arrayList);
            Assert.AreEqual(6.3M, basicCalculator.Result);
        }
        public void SumDoubleTest()
        {
            double[] arrayList = { 1.0, 2.0, 3.0 };
            Calculator.Sum(arrayList);
            Assert.AreEqual(6.0, basicCalculator.Result);
        }
    }
}