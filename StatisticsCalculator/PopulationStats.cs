using System;
using BasicCalculator;
using Microsoft.CSharp;

namespace StatisticsCalculator
{
    public class PopulationStats : basicCalculator
    {
       
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

        //public decimal ConfidenceInterval(dynamic DataPoints)
        //{



        //}

    }
}
