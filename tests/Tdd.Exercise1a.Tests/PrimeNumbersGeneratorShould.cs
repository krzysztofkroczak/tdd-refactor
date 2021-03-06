using Xunit;

namespace Tdd.Exercise1a.Tests
{
    public class PrimeNumbersGeneratorShould
    {
        [Theory]
        [InlineData(0, new int[0])]
        [InlineData(1, new int[0])]
        [InlineData(2, new[] {2})]
        [InlineData(3, new[] {2, 3})]
        [InlineData(4, new[] {2, 3})]
        [InlineData(10, new[] {2, 3, 5, 7})]
        [InlineData(30, new[] {2, 3, 5, 7, 11, 13, 17, 19, 23, 29})]
        [InlineData(50, new[] {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47})]
        public void GenerateListUpUntilLimit(int limit, int[] expectedPrimeNumbers)
        {
            var generator = new PrimeNumbersGenerator();

            var resultPrimeNumbers = generator.Generate(limit);

            Assert.Equal(expectedPrimeNumbers, resultPrimeNumbers);
        }
    }
}
