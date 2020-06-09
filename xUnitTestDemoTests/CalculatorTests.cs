using Xunit;

namespace xUnitTestDemo.Tests
{
    public class CalculatorTests
    {
        [Fact()]
        public void AddTest()
        {
            // Arrange
            var sut = new Calculator();// System under test

            // Act
            var result = sut.Add(1, 2);

            // Assert
            Assert.Equal(3, result);
        }
    }
}