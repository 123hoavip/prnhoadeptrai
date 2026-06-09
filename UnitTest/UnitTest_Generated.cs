using Xunit;
using DemoUnitTest_ConsoleApp; // Assuming this is where Calculator resides

namespace DemoUnitTest_Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new Calculator();

        // --- Add Tests ---
        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 10;
            int expected = 15;

            // Act
            int actual = _calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Add_NegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = -5;
            int b = -10;
            int expected = -15;

            // Act
            int actual = _calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Add_WithZero_ReturnsOriginalNumber()
        {
            // Arrange
            int a = 7;
            int b = 0;
            int expected = 7;

            // Act
            int actual = _calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }


        // --- Subtract Tests ---
        [Fact]
        public void Subtract_BasicSubtraction_ReturnsDifference()
        {
            // Arrange
            int a = 10;
            int b = 3;
            int expected = 7;

            // Act
            int actual = _calculator.Subtract(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Subtract_ResultIsNegative_ReturnsCorrectDifference()
        {
            // Arrange
            int a = 3;
            int b = 10;
            int expected = -7;

            // Act
            int actual = _calculator.Subtract(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }


        // --- Multiply Tests ---
        [Fact]
        public void Multiply_TwoPositiveNumbers_ReturnsProduct()
        {
            // Arrange
            int a = 6;
            int b = 7;
            int expected = 42;

            // Act
            int actual = _calculator.Multiply(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Multiply_ByZero_ReturnsZero()
        {
            // Arrange
            int a = 99;
            int b = 0;
            int expected = 0;

            // Act
            int actual = _calculator.Multiply(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }


        // --- Divide Tests ---
        [Fact]
        public void Divide_BasicDivision_ReturnsCorrectQuotient()
        {
            // Arrange
            double a = 10.0;
            double b = 2.0;
            double expected = 5.0;

            // Act
            double actual = _calculator.Divide(a, b);

            // Assert (Using tolerance for double comparison)
            Assert.Equal(expected, actual, 4); 
        }

        [Fact]
        public void Divide_FloatingPointResult_ReturnsCorrectQuotient()
        {
            // Arrange
            double a = 10.0;
            double b = 3.0;
            double expected = 3.3333333333333335; // The actual double representation

            // Act
            double actual = _calculator.Divide(a, b);

            // Assert (Using tolerance for double comparison)
            Assert.Equal(expected, actual, 4); 
        }


        [Fact]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            double a = 10.0;
            double b = 0.0;

            // Act & Assert: We expect the specific exception to be thrown
            var ex = Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
            
            // Optional: Check the message content for robustness
            Assert.Contains("Cannot divide by zero.", ex.Message);
        }
    }
}