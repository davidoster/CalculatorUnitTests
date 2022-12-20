using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class ArithmeticCalculations : IArithmeticCalculations
    {
        private INumberValidator _numberValidator;

        public ArithmeticCalculations(INumberValidator numberValidator)
        {
            _numberValidator = numberValidator;
        }

        public int Add(int number1, int number2)
        {
            //NumberValidator numberValidator = new NumberValidator();
            try
            {
                _numberValidator.Value = number1;
                int n1 = _numberValidator.Value; // throw

                _numberValidator.Value = number2;
                int n2 = _numberValidator.Value; // throw
                return n1 + n2;
            } 
            catch(Exception ex) 
            { 
                throw new Exception(ex.Message);
            }
        }

        public int Divide(int number1, int number2)
        {
            return number1 / number2;
        }

        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}
