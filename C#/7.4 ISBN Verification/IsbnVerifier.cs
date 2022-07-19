using System;

namespace IsbnVerification
{
    public static class IsbnVerifier
    {
        /// <summary>
        /// Verifies if the string representation of number is a valid ISBN-10 identification number of book.
        /// </summary>
        /// <param name="number">The string representation of book's number.</param>
        /// <returns>true if number is a valid ISBN-10 identification number of book, false otherwise.</returns>
        /// <exception cref="ArgumentException">Thrown if number is null or empty or whitespace.</exception>
        public static bool IsValid(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
            {
                throw new ArgumentException("The number is null, or empty, or whitespace", nameof(number));
            }

            const int sumElemAmount = 10;
            const int numberForX = 10;

            int sum = 0;
            int j = sumElemAmount;
            for (int i = 0; i < number.Length && j >= 0; i++)
            {
                if (number[i] >= '0' && number[i] <= '9')
                {
                    sum += (number[i] - '0') * j;
                    j--;
                }
                else if (number[i] == 'X' && j == 1)
                {
                    sum += numberForX * j;
                    j--;
                }
                else if (number[i] != '-' || !IsPlaceForHyphen(i))
                {
                    return false;
                }
            }

            if (j != 0)
            {
                return false;
            }

            if (sum % 11 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsPlaceForHyphen(int i)
        {
            const int hyphenPlace1 = 1;
            const int hyphenPlace2 = 5;
            const int hyphenPlace3 = 11;
            if (i == hyphenPlace1 || i == hyphenPlace2 || i == hyphenPlace3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
