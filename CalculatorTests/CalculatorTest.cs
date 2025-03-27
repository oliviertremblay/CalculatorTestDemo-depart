using CalculatorTestDemo;
namespace CalculatorTests
{
    public class CalculatorTest
    {
        [Fact]
        public void GivenAdditionParameters_ThenReturnCorrectSum()
        {
            // Arrange: préparation des données
            Calculator calculator = new Calculator();
            int a = 5;
            int b = 3;
            int expected = 8;

            // Act: exécution de la méthode à tester
            int result = calculator.Add(a, b);

            // Assert: vérification du résultat
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(4, 4, 16)]
        [InlineData(5, 3, 15)]
        [InlineData(6, 2, 12)]
        public void GivenMultiplicationParameters_ThenReturnCorrectProduct(int a, int b, int expected)
        {
            // Arrange: préparation des données
            Calculator calculator = new Calculator();

            // Act: exécution de la méthode à tester
            int result = calculator.Multiply(a, b);

            // Assert: vérification du résultat
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GivenDivisionByZero_ThenThrowDivideByZeroException()
        {
            Calculator calculator = new Calculator();

            int a = 1;
            int b = 0;

            Assert.Throws<DivideByZeroException>(() => calculator.Divide(a, b));
        }
    }
}