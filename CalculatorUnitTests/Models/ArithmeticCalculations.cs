using CalculatorUnitTests;
using CalculatorUnitTests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    
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
            _arithmeticOperationValidator = new ArithmeticOperationValidator();
        }

        public int? Add(int number1, int number2)
        {
            _arithmeticOperationValidator.Validate(number1, number2, ArithmeticOperations.ADD);
            if (_arithmeticOperationValidator.State == ArithmeticOperationsStates.OK)
            {
                return number1 + number2;
            }
            return null;
        }

        public int? Divide(int number1, int number2)
        {
            _arithmeticOperationValidator.Validate(number1, number2, ArithmeticOperations.DIVIDE);
            if (_arithmeticOperationValidator.State == ArithmeticOperationsStates.OK)
            {
                return number1 / number2;
            }
            return null;
        }

        public int? Multiply(int number1, int number2)
        {
            _arithmeticOperationValidator.Validate(number1, number2, ArithmeticOperations.MULTIPLY);
            if (_arithmeticOperationValidator.State == ArithmeticOperationsStates.OK)
            {
                return number1 * number2;
            }
            return null;
        }

        public int? Subtract(int number1, int number2)
        {
            _arithmeticOperationValidator.Validate(number1, number2, ArithmeticOperations.SUBTRACT);
            if(_arithmeticOperationValidator.State == ArithmeticOperationsStates.OK)
            {
                return number1 - number2;
            }
            return null;
        }
    }
}
