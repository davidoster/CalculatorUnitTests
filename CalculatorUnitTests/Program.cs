using Calculator.Models;
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
            ArithmeticCalculations arithmeticCalculations = new ArithmeticCalculations(1);
            //NumberValidator.Precision = 1;
            //Console.WriteLine(arithmeticCalculations.Add(-int.MaxValue, -int.MaxValue));
            Console.WriteLine(arithmeticCalculations.Subtract(1, 1));
            //arithmeticCalculations.Multiply(1, 1);
            //arithmeticCaclulations.Divide(22, 0);
            Console.WriteLine(
                $"Add(11,11)=" +
                $"{arithmeticCalculations.DoOperation(11, 11, ArithmeticOperations.ADD)}" +
                $"\nSubtract(11,11)=" +
                $"{arithmeticCalculations.DoOperation(11, 11, ArithmeticOperations.SUBTRACT)}" +
                $"\nMultiply(11,11)=" +
                $"{arithmeticCalculations.DoOperation(11, 11, ArithmeticOperations.MULTIPLY)}" +
                $"\nDivide(11,1)=" +
                $"{arithmeticCalculations.DoOperation(11, 1, ArithmeticOperations.DIVIDE)}");
        }
    }
}
