using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticsCalculator;

namespace StatisticsCalculatorTests
{
    [TestClass]
    public class StatsCalcTest
    {
        [TestMethod]
        public void MeanTest()
        {
            double[] DataPoints = { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0 };
            DescriptiveStats statsCalc = new DescriptiveStats();
            var result = statsCalc.Mean(DataPoints);
            Assert.AreEqual(3.5, result);
        }
        [TestMethod]
        public void MedianTest()
        {
            double[] DataPoints = { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0 };
            DescriptiveStats statsCalc = new DescriptiveStats();
            var result = statsCalc.Median(DataPoints);
            Assert.AreEqual(3.5, result);
        }

        [TestMethod]
        public void ModeTest()
        {
            double[] DataPoints = { 1.0, 2.0, 2.0, 3.0, 4.0, 5.0, 6.0, 6.0, 2.0 };
            DescriptiveStats statsCalc = new DescriptiveStats();
            var result = statsCalc.Mode(DataPoints);
            Assert.AreEqual(2.0, result);
        }

        [TestMethod]
        public void VarianceTest()
        {
            double[] DataPoints = { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0 };
            DescriptiveStats statsCalc = new DescriptiveStats();
            var result = statsCalc.Variance(DataPoints);
            Assert.AreEqual(3.5, result);
        }

        [TestMethod]
        public void StdDevTest()
        {
            double[] DataPoints = { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0 };
            DescriptiveStats statsCalc = new DescriptiveStats();
            var result = statsCalc.StdDev(DataPoints);
            Assert.AreEqual(1.8708286933869707, result);
        }

        [TestMethod]
        public void SkewnessTest()
        {
            double[] DataPoints = { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0};
            DescriptiveStats statsCalc = new DescriptiveStats();
            var result = statsCalc.Skewness(DataPoints);
            Assert.AreEqual(0.0, result);
        }

        [TestMethod]
        public void SamCorrelationTest()
        {
            double[] DataPointsX = { 3.0, 3.0, 6.0};
            double[] DataPointsY = { 2.0, 3.0, 4.0 };
            DescriptiveStats statsCalc = new DescriptiveStats();
            var result = statsCalc.SampleCoefficient(DataPointsX, DataPointsY);
            Assert.AreEqual(0.8660254037844387, result);
        }

        [TestMethod]
        public void PopCorrelationTest()
        {
            double[] DataPointsX = { 1, 2, 3, 4, 5 };
            double[] DataPointsY = { 11, 22, 34, 43, 56 };
            DescriptiveStats statsCalc = new DescriptiveStats();
            var result = statsCalc.PopCoefficient(DataPointsX, DataPointsY);
            Assert.AreEqual(0.7991248857909374, result);
        }

        [TestMethod]
        public void ZScoresTest()
        {
            double[] DataPoints = { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0 };
            double[] scores = { -1.3363062095621219, -0.449056948958286, 0.05601104036639116, 0.5284884801832448, 1.0840732389765304, 1.926539846563328 };
            DescriptiveStats statsCalc = new DescriptiveStats();
            var result = statsCalc.ZScore(DataPoints);
            CollectionAssert.AreEqual(scores, result);
        }

        [TestMethod]
        public void MeanDeviationTest()
        {
            double[] DataPoints = { 12.0, 24.0, 41.0, 51.0, 67.0, 67.0, 85.0, 99.0 };
            DescriptiveStats statsCalc = new DescriptiveStats();
            var result = statsCalc.MeanDeviation(DataPoints);
            Assert.AreEqual(23.75, result);
        }

        [TestMethod]
        public void SampleRandomSampleTest()
        {
            decimal sample = 10M;
            decimal population = 100M;

            PopulationStats statsCalc = new PopulationStats();
            var result = statsCalc.SimpleRandomSample(sample, population);
            Assert.AreEqual(0.10M, result);
        }

        [TestMethod]
        public void SystematicSamplingTest()
        {
            decimal sample = 10M;
            decimal population = 100M;

            PopulationStats statsCalc = new PopulationStats();
            var result = statsCalc.SystematicSampling(sample, population);
            Assert.AreEqual(10M, result);
        }
    }
}
