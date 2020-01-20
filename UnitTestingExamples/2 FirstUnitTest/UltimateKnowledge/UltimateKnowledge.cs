using System;

namespace UltimateKnowledge
{
    /// <summary>
    /// Source of the answer to life the universe and everything.
    /// </summary>
    public class UltimateKnowledge
    {
        static readonly int TheUltimateAnswer = 42;

        /// <summary>
        /// Returns the ultimate answer.
        /// </summary>
        /// <returns>Answer to life the universe and everything</returns>
        public int UltimateAnswer => TheUltimateAnswer;

        /// <summary>
        /// Checks if parameter is more than the ultimate answer.
        /// </summary>
        /// <param name="input">Input any integer value</param>
        /// <returns>True if input is more than The Ultimate Answer</returns>
        /// <exception cref="ArgumentOutOfRangeException">Input must be correlated to The Ultimate Answer!</exception>
        public bool IsMore(int input)
        {
            var isTheUltimateAnswer = IsTheUltimateAnswer(input);
            if (!isTheUltimateAnswer)
            {
                throw new ArgumentOutOfRangeException(nameof(input), input,
                    "Nothing can be more than the ultimate answer!");
            }
            else
            {
                return isTheUltimateAnswer;
            }
        }

        /// <summary>
        /// Determines whether the parameter is equal to The Ultimate Answer.
        /// </summary>
        /// <param name="input">Any integer value</param>
        /// <returns>True, if input is equal to The Ultimate Answer, otherwise false</returns>
        public bool IsTheUltimateAnswer(int input) => TheUltimateAnswer == input;

    }
}
