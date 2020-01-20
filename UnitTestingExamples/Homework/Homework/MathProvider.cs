using System.Collections.Generic;
using System.Linq;
using NLog;

namespace Homework
{
    public class MathProvider
    {
        static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        public ICalculator Calculator { get; set; }

        public string Sum(IEnumerable<int> numbers)
        {
            Logger.Info("Calculating sum of a list of number");
            var result = numbers.Aggregate(Calculator.Calculate);
            Logger.Info($"Calculation finished! Result is {result}");

            var formatter  = new NumberFormatter();
            return formatter.Format(result);
        }
    }
}
