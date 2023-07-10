using Calculator;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        readonly double [] numbers = { 5, 2 };
        [Fact]
        public void CheckSumMethodIsCorrect()
        {
            double result = CalcOperations.Sum(numbers);
            double expected = 7;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CheckSubtractMethodIsCorrect()
        {
            double result = CalcOperations.Subtract(numbers);
            double expected = 3;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CheckMultiplyMethodIsCorrect()
        {
            double result = CalcOperations.Multiply(numbers);
            double expected = 10;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CheckDivideMethodIsCorrect()
        {
            double result = CalcOperations.Divide(numbers);
            double expected = 2.5;

            Assert.Equal(expected, result);
        }
    }
}