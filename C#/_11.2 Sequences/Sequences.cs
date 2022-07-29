using System;

namespace Sequences
{
    public static class Sequences
    {
        /// <summary>
        /// Find all the contiguous substrings of "length" length in given string of digits in the order that they appear.
        /// </summary>
        /// <param name="numbers">Source string.</param>
        /// <param name="length">Length of substring.</param>
        /// <returns>All the contiguous substrings of length n in that string in the order that they appear.</returns>
        /// <exception cref="ArgumentException">
        /// Throw if length of substring less and equals zero
        /// -or-
        /// more than length of source string
        /// - or-
        /// source string containing a non-digit character
        /// - or
        /// source string is null or empty or white space.
        /// </exception>
        public static string[] GetSubstrings(string numbers, int length)
        {
            if (length <= 0)
            {
                throw new ArgumentException("Length of substring is less than or equals zero.", nameof(length));
            }

            if (length > numbers.Length)
            {
                throw new ArgumentException("Length of substring is greater than length of source string.", nameof(length));
            }

            if (string.IsNullOrWhiteSpace(numbers))
            {
                throw new ArgumentException("Source string is null or empty or white space.", nameof(numbers));
            }

            if (!numbers.All(char.IsDigit))
            {
                throw new ArgumentException("Source string contains a non-digit character.", nameof(numbers));
            }

            string[] substrings = new string[numbers.Length - length + 1];
            for (int i = 0; i < substrings.Length; i++)
            {
                substrings[i] = numbers.Substring(i, length);
            }

            return substrings;
        }
    }
}
