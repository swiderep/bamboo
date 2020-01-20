using System;

namespace Calculator
{
    public class Sum
    {
        public int Calculate(string a, string b)
        {
            var first = ParseInt(a);
            var second = ParseInt(b);
            return first + second;

        }

        int ParseInt(string input)
        {
            ValidateNotNull(input);
            return DoParseInt(input);
        }

        int DoParseInt(string input)
        {
            int result;
            try
            {
                result = int.Parse(input);
            }
            catch(FormatException exception)
            {
                throw new FormatException("Only int value is accepted!", exception);

            }
            return result;
        }

        void ValidateNotNull(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Null parameter is illegal!");
            }
        }
    }
}
