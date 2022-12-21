using CalculatorUnitTests;

namespace Calculator.Models
{
    public interface IArithmeticOperationValidator //: INumberValidator
    {
        ArithmeticOperationsStates State { get; }
        void Validate(int number1, int number2, ArithmeticOperations operation);
    }
}