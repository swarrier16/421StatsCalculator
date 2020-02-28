using System;
using BasicCalculator;
using Microsoft.CSharp;
using MathNet;
using RandomGen;

namespace StatisticsCalculator
{
    public class PopulationStats : basicCalculator
    {
        DescriptiveStats statsCalc = new DescriptiveStats();

        public decimal SimpleRandomSample(dynamic sample, dynamic population)
        {

            decimal samplesize = Quotient(sample, population);
            return samplesize;

        }

        public decimal SystematicSampling(dynamic sample, dynamic population)
        {

            decimal k = Quotient(population, sample);
            return k;

        }

        public double MarginOfError(dynamic DataPoints)
        {
            int n = DataPoints.Length;

            double deviation = statsCalc.StdDev(DataPoints);

            var curve = new MathNet.Numerics.Distributions.Normal();
            var z = curve.InverseCumulativeDistribution(0.95);

            double error = (z * (deviation / Root(n)));
            error = Math.Round(error, 3);

            return error;

        }

        public double[] ConfidenceInterval(dynamic DataPoints)
        {

            double xbar = statsCalc.Mean(DataPoints);
            double plus = xbar + MarginOfError(DataPoints);
            double minus = xbar - MarginOfError(DataPoints);

            plus = Math.Round(plus, 3);
            minus = Math.Round(minus, 3);

            double[] interval = new double[] { minus, plus };

            return interval;

        }

        public double CochranFormula(dynamic DataPoints, dynamic populationPresent)
        {

            var curve = new MathNet.Numerics.Distributions.Normal();
            var z = curve.InverseCumulativeDistribution(0.95);
            var p = populationPresent;
            var q = 1 - p;
            var e = MarginOfError(DataPoints);

            Console.WriteLine(e);

            double result = (Power(z, 2) * p * q) / Power(e, 2);
            result = Math.Round(result, 3);
            return result;

        }



    }
}
