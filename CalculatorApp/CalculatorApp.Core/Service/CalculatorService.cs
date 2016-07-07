namespace CalculatorApp.Core.Services
{
    public class CalculatorService : ICalculatorService
    {
        public double Sum(double numberOne, double numberTwo)
        {
            return numberOne + numberTwo;
        }

        public double Subtract(double numberOne, double numberTwo)
        {
            return numberOne - numberTwo;
        }

        public double Multiply(double numberOne, double numberTwo)
        {
            return numberOne * numberTwo;
        }

        public double Divide(double numberOne, double numberTwo)
        {
            return numberOne / numberTwo;
        }
    }

    public interface ICalculatorService
    {
        double Sum(double numberOne, double numberTwo);
        double Subtract(double numberOne, double numberTwo);
        double Multiply(double numberOne, double numberTwo);
        double Divide(double numberOne, double numberTwo);
    }
}