using System;
using CalculatorAppLibrary.Services;
using Xunit;

namespace CalculatorAppLibrary.Tests
{
    public class MathOperationsServiceTests
    {
        private readonly IMathOperationsService _mathOperationsService;

        public MathOperationsServiceTests()
        {
            _mathOperationsService = new MathOperationsService();
        }

        [InlineData(29,39, 68)]
        [Theory]
        public void AssertSumReturnCorrectValue(double firstNumber, double secondNumber, double expected)
        {

            var actual = _mathOperationsService.Sum(firstNumber, secondNumber);
            Assert.Equal(expected,actual);
        }

        [InlineData(29, 39, -10)]
        [Theory]
        public void AssertSubtractReturnCorrectValue(double firstNumber, double secondNumber, double expected)
        {

            var actual = _mathOperationsService.Subtract(firstNumber, secondNumber);
            Assert.Equal(expected, actual);
        }

        [InlineData(29, 10, 290)]
        [Theory]
        public void AssertMultiplyReturnCorrectValue(double firstNumber, double secondNumber, double expected)
        {

            var actual = _mathOperationsService.Multiply(firstNumber, secondNumber);
            Assert.Equal(expected, actual);
        }

        [InlineData(290, 10, 29)]
        [Theory]
        public void AssertDivideReturnCorrectValue(double firstNumber, double secondNumber, double expected)
        {

            var actual = _mathOperationsService.Divide(firstNumber, secondNumber);
            Assert.Equal(expected, actual);
        }

        [InlineData(290, 0)]
        [Theory]
        public void AssertDivideByZeroThrowException(double firstNumber, double secondNumber)
        {
            Assert.Throws<DivideByZeroException>(() => _mathOperationsService.Divide(firstNumber, secondNumber));
        }
    }
}
