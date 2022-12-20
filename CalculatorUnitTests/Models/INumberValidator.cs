namespace Calculator.Models
{
    public interface INumberValidator
    {
        //static int Precision = 2; // only from .NET Core onwards
        int Value { get; set; }
    }
}