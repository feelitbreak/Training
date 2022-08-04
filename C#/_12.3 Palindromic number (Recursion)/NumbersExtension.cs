using System;

namespace PalindromicNumberTask
{
    /// <summary>
    /// Provides static method for working with integers.
    /// </summary>
    public static class NumbersExtension
    {
        private const int DecBase = 10;

        /// <summary>
        /// Determines if a number is a palindromic number, see https://en.wikipedia.org/wiki/Palindromic_number.
        /// </summary>
        /// <param name="number">Verified number.</param>
        /// <returns>true if the verified number is palindromic number; otherwise, false.</returns>
        /// <exception cref="ArgumentException"> Thrown when source number is less than zero. </exception>
        public static bool IsPalindromicNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Source number is less than zero.", nameof(number));
            }

            int copyNum = number;
            return IsPalindromicNumber(number, ref copyNum);
        }

        private static bool IsPalindromicNumber(int number, ref int copyNum)
        {
            if (number.IsOneDigit())
            {
                if (number == copyNum % DecBase)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (!IsPalindromicNumber(number / DecBase, ref copyNum))
            {
                return false;
            }

            copyNum /= DecBase;

            if (number % DecBase == copyNum % DecBase)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsOneDigit(this int number)
        {
            return number >= 0 && number < DecBase;
        }
    }
}
