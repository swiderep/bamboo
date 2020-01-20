using FluentAssertions;
using NUnit.Framework;

namespace CalculatorTests
{
    namespace Classic
    {
        [TestFixture]
        public class CalculatorTests
        {
            [Test]
            public void Add_PositiveNumber_ReturnsIncreasedValue()
            {
                // Arrange
                var calc = new Calculator.Calculator();

                // Act
                var result = calc.Add(5);

                // Assert
                Assert.AreEqual(5, result);
            }

        }
    }

    namespace BDDStyle
    {
        [TestFixture]
        public class WhenIAddNumbers
        {
            [Test]
            public void ThenTheValueShouldBeIncreased()
            {
                // Arrange
                var calc = new Calculator.Calculator();

                // Act
                var result = calc.Add(5);

                // Assert
                Assert.AreEqual(5, result);
            }

        }
    }

    namespace FluentAssertion
    {
        [TestFixture]
        public class WhenIAddNumbers
        {
            [Test]
            public void ThenTheValueShouldBeIncreased()
            {
                // Arrange
                var calc = new Calculator.Calculator();

                // Act
                var result = calc.Add(5);

                // Assert
                result.Should().Be(5);
            }
        }
    }
}
