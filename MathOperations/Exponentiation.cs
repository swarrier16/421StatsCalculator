using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations
{
    public static class Exponentiation
    {
        static public double Power(double _base, double exponent)
        {
            var power = Math.Pow(_base, exponent);
            return power;
        }

    }
}