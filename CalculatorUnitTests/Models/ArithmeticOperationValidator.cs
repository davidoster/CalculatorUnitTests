using Calculator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUnitTests.Models
{
    // ArithmeticOperationValidator (State Of an operation)
    // get the 1st number <--- NumberValidator
    // get the 2nd number <--- NumberValidator
    // get the operation  <--- OperationValidator
    // check that these(the above) are valid in all cases so proceed with the operation 
    internal class ArithmeticOperationValidator : IArithmeticOperationValidator
    {
        //public int Number1;
        //public int Number2;
        public ArithmeticOperationsStates State { private set; get; } // Enum
        public int Result;

        public ArithmeticOperationValidator()
        {

        }

        public ArithmeticOperationValidator(int number1, int number2, ArithmeticOperations operation)
        {
            Validate(number1, number2, operation);

        }

        public void Validate(int number1, int number2, ArithmeticOperations operation)
        {
            NumberValidator number1Validator = new NumberValidator();
            number1Validator.Value = number1;
            NumberValidator number2Validator = new NumberValidator();
            number2Validator.Value = number2;
            try
            {
                // operation
                //Add(number1Validator.Value, number2Validator.Value);
                switch (operation)
                {
                    case ArithmeticOperations.ADD:
                        State = ArithmeticOperationsStates.OK;
                        break;
                    case ArithmeticOperations.SUBTRACT:
                        State = ArithmeticOperationsStates.OK;
                        break;
                    case ArithmeticOperations.DIVIDE:
                        if (number2Validator.Value != 0)
                        {
                            State = ArithmeticOperationsStates.OK;
                        }
                        else
                        {
                            State = ArithmeticOperationsStates.NUMBER2NOTVALIDDIVISIONBYZERO;
                            throw new Exception("Number2 is not allowed to be zero");
                        }
                        break;
                    case ArithmeticOperations.MULTIPLY:
                        State = ArithmeticOperationsStates.OK;
                        break;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
