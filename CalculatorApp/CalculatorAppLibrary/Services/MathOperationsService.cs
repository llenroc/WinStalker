using System;

namespace CalculatorAppLibrary.Services
{
    public class MathOperationsService : IMathOperationsService
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
            if(Math.Abs(numberTwo) < 0.001) throw new DivideByZeroException();
            return numberOne / numberTwo;
        }
    }

    public interface IMathOperationsService
    {
        double Sum(double numberOne, double numberTwo);
        double Subtract(double numberOne, double numberTwo);
        double Multiply(double numberOne, double numberTwo);
        double Divide(double numberOne, double numberTwo);
    }
}