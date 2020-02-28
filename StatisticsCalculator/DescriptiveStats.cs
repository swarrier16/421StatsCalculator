using System;
using BasicCalculator;
using Microsoft.CSharp;

namespace StatisticsCalculator
{
    public class DescriptiveStats : basicCalculator
    {
        public double Mean(dynamic DataPoints)
        {

            var countDataPoints = DataPoints.Length;
            double dataPointSum = Sum(DataPoints);

            Result = dataPointSum / countDataPoints;

            return Result;
        }


        public double Median(dynamic DataPoints)
        {
            double[] values = DataPoints;
            var size = values.Length;


            if (size % 2 == 0)
            {
                double a = values[size / 2 - 1];
                double b = values[size / 2];
                return (a + b) / 2;
            }
            else
            {
                return values[(size / 2)];
            }
        }

        public double Mode(dynamic DataPoints)
        {
            double[] values = DataPoints;
            int[] count = new int[values.Length];
            double highestCount = 0;

            for (int i = 0; i < values.Length; i++)
            {
                for (int y = 1; y < values.Length; y++)
                {
                    if (values[y] == i)
                    {
                        count[i]++;
                    }
                }
                //loop through each instance and count how many times each appears
            }
            for (int x = 0; x < count.Length - 1; x++)
            {
                if (count[x] > count[x + 1])
                {
                    highestCount = values[x];
                }
                else
                {
                    highestCount = values[x + 1];
                }
            }
            return highestCount;
        }

        public double Variance(dynamic DataPoints)
        {

            double mean = Mean(DataPoints);
            double sumOfSquares = 0;

            foreach (double num in DataPoints)
            {
                sumOfSquares += Power((num - mean), 2.0);

            }

            return sumOfSquares / (DataPoints.Length - 1);
        }


        public double StdDev(dynamic DataPoints)
        {
            return Math.Sqrt(Variance(DataPoints));
        }


        public double Skewness(dynamic DataPoints)
        {
            var numerator = 3 * (Mean(DataPoints) - Median(DataPoints));
            return (numerator / StdDev(DataPoints));

        }

        public double SampleCoefficient(dynamic DataPointsX, dynamic DataPointsY)
        {
            double xbar = Mean(DataPointsX);
            double ybar = Mean(DataPointsY);
            double sx = StdDev(DataPointsX);
            double sy = StdDev(DataPointsY);
            double x, y, numerator, expression, correlation;
            double final = 0;


            for (int i = 0; i < DataPointsX.Length; i++)
            {
                x = DataPointsX[i] - xbar;
                y = DataPointsY[i] - ybar;
                numerator = x * y;
                final = final + numerator;
            }

            expression = final / (sx * sy);
            correlation = expression / (DataPointsX.Length - 1);

            return correlation;

        }

        public double PopCoefficient(dynamic DataPointsX, dynamic DataPointsY)
        {
            double xbar = Mean(DataPointsX);
            double ybar = Mean(DataPointsY);
            double sx = StdDev(DataPointsX);
            double sy = StdDev(DataPointsY);
            double x, y, numerator, expression, correlation;
            double covariance = 0;


            for (int i = 0; i < DataPointsX.Length; i++)
            {
                x = DataPointsX[i] - xbar;
                y = DataPointsY[i] - ybar;
                numerator = x * y;
                covariance = covariance + numerator;
            }

            expression = covariance / DataPointsX.Length;
            correlation = (expression/ (sx * sy));

            return correlation;

        }
        public double MeanDeviation(dynamic DataPoints)
        {
            double xbar = Mean(DataPoints);
            double num = 0;
            double final;

            for (int i = 0; i < DataPoints.Length; i++)
            {
                num = num + Math.Abs((DataPoints[i] - xbar));
            }

            final = num / DataPoints.Length;

            return final;

        }

        public double[] ZScore(dynamic DataPoints)
        {
            double[] zscores = DataPoints;
            double z;

            for (int i = 0; i < DataPoints.Length; i++)
            {
                z = ((DataPoints[i] - Mean(DataPoints)) / StdDev(DataPoints));
                zscores[i] = z;

            }

            for (int i = 0; i < zscores.Length; i++)
            {
                Console.WriteLine(zscores[i]);
            }

                return zscores;

        }
    }

}

        
    

    


