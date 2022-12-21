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

        public ArithmeticCalculations(int precision)
        {
            NumberValidator.Precision = precision;
            _arithmeticOperationValidator = new ArithmeticOperationValidator();
        }

        public ArithmeticCalculations(IArithmeticOperationValidator arithmeticOperationValidator)
        {
            _arithmeticOperationValidator = arithmeticOperationValidator;
        }

        public ArithmeticCalculations(INumberValidator numberValidator)
        {
            _numberValidator = numberValidator;
            _arithmeticOperationValidator = new ArithmeticOperationValidator();
        }

        public int? DoOperation(int number1, int number2, ArithmeticOperations arithmeticOperation)
        {
            int? result = null;
            _arithmeticOperationValidator.Validate(number1, number2, arithmeticOperation);
            if (_arithmeticOperationValidator.State == ArithmeticOperationsStates.OK)
            {
                switch (arithmeticOperation)
                {
                    case ArithmeticOperations.ADD:
                        result = AddPrivate(number1, number2);
                        break;
                    case ArithmeticOperations.SUBTRACT:
                        result = SubtractPrivate(number1, number2);
                        break;
                    case ArithmeticOperations.MULTIPLY:
                        result = MultiplyPrivate(number1, number2);
                        break;
                    case ArithmeticOperations.DIVIDE:
                        result = DividePrivate(number1, number2);
                        break;
                }
            }
            return result;
        }

        public int? Add(int number1, int number2)
        {
            return DoOperation(number1, number2, ArithmeticOperations.ADD);
        }

        public int? Divide(int number1, int number2)
        {
            return DoOperation(number1, number2, ArithmeticOperations.DIVIDE);
        }

        public int? Multiply(int number1, int number2)
        {
            return DoOperation(number1, number2, ArithmeticOperations.MULTIPLY);
        }

        public int? Subtract(int number1, int number2)
        {
            return DoOperation(number1, number2, ArithmeticOperations.SUBTRACT);
        }


        private int? AddPrivate(int number1, int number2)
        {
            return number1 + number2;
        }

        private int? SubtractPrivate(int number1, int number2)
        {
            return number1 - number2;
        }

        private int? MultiplyPrivate(int number1, int number2)
        {
            return number1 * number2;
        }

        private int? DividePrivate(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}
