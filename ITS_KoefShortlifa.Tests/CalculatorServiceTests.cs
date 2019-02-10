using FluentAssertions;
using NUnit.Framework;

namespace ITS_KoefShortlifa.Tests
{
    public class CalculatorServiceTests
    {
        [Test]
        public void Should_return_correct_value()
        {
            // Arrange
            var sut = new CalculatorService();
            var expectedValue = 0.68;
            var values = new double[]
            {
                0.5, 0.7, 0.6, 0.7, 0.6, 0.8, 0.8, 0, 0.8, 0.6
            };

            // Act
            var value = sut.GetValue(values);

            // Assert
            value.Should().BeApproximately(expectedValue, 0.01);
        }
    }
}
