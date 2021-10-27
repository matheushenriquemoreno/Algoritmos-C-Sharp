using System;
using Delegates.Services;
namespace Delegates
{
    delegate void BinaryNumericOperetion(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {

            double a = 10;
            double b = 16;
            double c = 14;
            double d = 23;

            //BinaryNumericOperetion op = Calculation.Max;

            BinaryNumericOperetion op2 = Calculation.ShowSum;
            op2 += Calculation.ShowMax;

            op2.Invoke(a, b);
            op2(c, d);

            //double resultado = op(a, b);




        }
    }
}
