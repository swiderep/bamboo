namespace Homework
{
    public class Sum : AbstractCalculator
    {
        protected override int DoCalculate(int a, int b)
        {
            var result = a + b;
            return result;
        }
    }
}
