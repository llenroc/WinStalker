using CalculatorApp.Core.Services;
using Xunit;

namespace CalculatorApp.Core.Tests.Unit.Service
{
    public class CalculatorServiceTests
    {
        [InlineData(10,20,30)]
        [Theory]
        public void AssertSumReturnsCorrectValue(double firstValue, double secondValue, double expected)
        {
            var calculatorService = new CalculatorService();
            var actual = calculatorService.Sum(firstValue, secondValue);

            Assert.Equal(expected, actual);
        }

    }
}
