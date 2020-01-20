using Fibonacci;
using FluentAssertions;
using NUnit.Framework;

namespace FibonacciCalcTests
{
    public class FibonacciTests
    {
        [TestCase(5, ExpectedResult = 5)]
        [TestCase(10, ExpectedResult = 55)]
        [TestCase(30, ExpectedResult = 832040)]
        public long ParameterizedTestWithTestCase(int input)
        {
            return FibonacciCalc.Fibonacci(input);
        }


        [Test]
        [TestCaseSource("FibonacciCases")]
        public void ParameterizedTestWithTheory(int input, int expected)
        {
            var result = FibonacciCalc.Fibonacci(input);
            result.Should().Be(expected);
        }

        static object[] FibonacciCases = {
            new[] {5, 5},
            new[] {10, 55},
            new[] {30, 832040 }
        };
    }
}
