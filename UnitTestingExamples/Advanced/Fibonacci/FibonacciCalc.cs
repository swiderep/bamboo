using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace Fibonacci
{
    public sealed class FibonacciCalc
    {
        public static long Fibonacci(long number)
        {
            if (number <= 1)
            {
                return number;
            }
            else
            {
                return Fibonacci(number-1) + Fibonacci(number - 2);
            }    
        }

        public static IEnumerable<long> Fibonacci2()
        {
            var a = 0L;
            var b = 1L;

            yield return a;

            while (true)
            {
                yield return b;
                b = a + b;
                a = b - a;
            }
        }
    }
}
