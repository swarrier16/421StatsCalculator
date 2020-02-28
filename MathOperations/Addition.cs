using System;

namespace MathOperations
{
    public static class Addition
    {
        public static void Main()
        {
        }
        static public int Sum(int augend, int addend)
        {
            var sum = augend + addend;
            return sum;
        }

        static public decimal Sum(decimal augend, decimal addend)
        {
            var sum = augend + addend;
            return sum;
        }

        static public decimal Sum(decimal[] doubleArray)
        {
            decimal result = 0;
            foreach (var x in doubleArray)
            {
                result = Sum(result, x);
            }

            return result;
        }
        static public int Sum(int[] doubleArray)
        {
            int result = 0;
            foreach (var x in doubleArray)
            {
                result = Sum(result, x);
            }

            return result;
        }

        static public double Sum(double[] doubleArray)
        {
            int result = 0;
            foreach (int x in doubleArray)
            {
                result = Sum(result, x);
            }

            return result;
        }
    }
}
