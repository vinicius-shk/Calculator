namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(new double[] { 2, 5 })]
        [InlineData(new double[] { 5, 10 })]
        [InlineData(new double[] { 2, 4 })]
        [InlineData(new double[] { 56, 3 })]
        public void CheckSumMethodIsCorrect(double[] numList)
        {
            double result = CalcOperations.Sum(numList);
            double expected = numList[0] + numList[1];

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new double[] { 2, 5 })]
        [InlineData(new double[] { 5, 10 })]
        [InlineData(new double[] { 2, 4 })]
        [InlineData(new double[] { 56, 3 })]
        public void CheckSubtractMethodIsCorrect(double[] numList)
        {
            double result = CalcOperations.Subtract(numList);
            double expected = numList[0] - numList[1];

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new double[] { 2, 5 })]
        [InlineData(new double[] { 5, 10 })]
        [InlineData(new double[] { 2, 4 })]
        [InlineData(new double[] { 56, 3 })]
        public void CheckMultiplyMethodIsCorrect(double[] numList)
        {
            double result = CalcOperations.Multiply(numList);
            double expected = numList[0] * numList[1];

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new double[] { 2, 5 })]
        [InlineData(new double[] { 5, 10 })]
        [InlineData(new double[] { 2, 4 })]
        [InlineData(new double[] { 56, 3 })]
        public void CheckDivideMethodIsCorrect(double[] numList)
        {
            double result = CalcOperations.Divide(numList);
            double expected = numList[0] / numList[1];

            Assert.Equal(expected, result);
        }
    }
}