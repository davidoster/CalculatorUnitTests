using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    // ArithmeticOperationValidator
    // get the 1st number <--- NumberValidator
    // get the 2nd number <--- NumberValidator
    // get the operation  <--- OperationValidator
    // check that these(the above) are valid in all cases so proceed wit the operation 
    public class ArithmeticCalculations : IArithmeticCalculations
    {
        private IArithmeticOperationValidator _arithmeticOperationValidator;
        private INumberValidator _numberValidator;

        public ArithmeticCalculations(IArithmeticOperationValidator arithmeticOperationValidator)
        {
            _arithmeticOperationValidator = arithmeticOperationValidator;
        }

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
            if(number2 == 0)
            {
                throw new DivideByZeroException(); // new Exception();
            }
            try
            {
                _numberValidator.Value = number1;
                int n1 = _numberValidator.Value;

                _numberValidator.Value = number2;
                int n2 = _numberValidator.Value;

                return n1 / n2;
            }
            catch (DivideByZeroException e)
            {
                throw new Exception(e.Message);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            
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
