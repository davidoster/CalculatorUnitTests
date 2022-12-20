using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithmeticCalculations arithmeticCaclulations = new ArithmeticCalculations();
            arithmeticCaclulations.Add(1, 1);
            arithmeticCaclulations.Subtract(1, 1);
            arithmeticCaclulations.Multiply(1, 1);
            arithmeticCaclulations.Divide(1, 1);
        }
    }
}
