using System;

namespace Homework
{
    public sealed class Validator
    {
        public static void ValidateNotNull<T>(T input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
