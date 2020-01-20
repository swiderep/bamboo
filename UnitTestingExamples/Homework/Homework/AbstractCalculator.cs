namespace Homework
{
    public abstract class AbstractCalculator : ICalculator
    {
        public int Calculate(int a, int b)
        {
            ValidateInput(a, b);
            return DoCalculate(a, b);
        }

        void ValidateInput(int a, int b)
        {
            Validator.ValidateNotNull(a);
            Validator.ValidateNotNull(b);
        }

        protected abstract int DoCalculate(int a, int b);
    }
}