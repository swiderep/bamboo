using System;
using System.Linq;

namespace Calculator
{
    public class Calculator
    {
        public Logger Log { get; set; }
        public Sum Sum { get; set; }


        public int CalculateSum(string input, string separator)
        {
            Log.Info("Calculation started");

            ValidateInput(input);

            var numbers = ParseInput(input, separator);
            var result = DoCalculate(numbers);

            Log.Info($"Calculation ended! Result is {result}!");
            return result;
        }

        int DoCalculate(string[] numbers)
        {
            var result = Convert.ToInt32(numbers.Aggregate((a, b) => Sum.Calculate(a, b).ToString()));
            return result;
        }

        string[] ParseInput(string input, string separator)
        {
            var numbers = input.Split(new [] { separator}, StringSplitOptions.RemoveEmptyEntries);
            return numbers;
        }

        void ValidateInput(string input)
        {
            ValidateNotNull(input);
            ValidateLenght(input);
        }

        void ValidateLenght(string input)
        {
            if (!input.Any())
            {
                throw new ArgumentException("Input must be at least 1 character length!");
            }
        }

        void ValidateNotNull(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Null value is illegal!");
            }
        }
    }
}
