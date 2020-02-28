using System;
using MathOperations;
using Addition;
using Subtraction;
using Multiplication;
using Division;
using Square;
using SquareRoot;

namespace BasicCalculator
{
    public class basicCalculator : IAdd, ISubtract, IMultiply, IDivide, ISquare, IRoot
    {

        private static dynamic _result;

        public static dynamic Result
        {
            get => _result;
            set => _result = value;
        }

        Adding Addition = new Adding();
        Subtracting Subtraction = new Subtracting();
        Multiplying Multiplication = new Multiplying();
        Dividing Division = new Dividing();
        Squaring Square = new Squaring();
        SquareRooting SquareRoot = new SquareRooting();

        public static void Main()
        {
        }

        public dynamic Sum(dynamic a, dynamic b)
        {
            Result = Addition.Sum(a, b);
            return Result;

        }
        public dynamic Sum(dynamic arrayList)
        {
            Result = Addition.Sum(arrayList);
            return Result;
        }
        public dynamic Difference(dynamic a, dynamic b)
        {
            Result = Subtraction.Difference(a, b);
            return Result;
        }
        public dynamic Product(dynamic a, dynamic b)
        {
            Result = Multiplication.Product(a, b); ;
            return Result;
        }
        public dynamic Quotient(dynamic a, dynamic b)
        {
            Result = Division.Quotient(a, b);
            return Result;
        }
        public dynamic Power(dynamic a, dynamic b)
        {
            Result = Exponentiation.Power(a, b);
            return Result;
        }
        public dynamic Root(dynamic a)
        {
            Result = Roots.Root(a);
            return Result;
        }
        /*public dynamic Log(dynamic a, dynamic b)
        {
            Result = Logrithm.Log(a, b);
            return Result;
        }*/
    }
}