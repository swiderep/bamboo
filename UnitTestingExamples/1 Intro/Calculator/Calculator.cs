namespace Calculator
{
    public class Calculator : ICalculator
    {
        public int CurrentValue { get; private set; }

        public int Add(int value) => CurrentValue += value;

        public int Substract(int value) => CurrentValue -= value;

        public int Multiply(int value) => CurrentValue *= value;

        public int Divide(int value) => CurrentValue /= value;

        public int Clear() => CurrentValue = 0;
    }
}
