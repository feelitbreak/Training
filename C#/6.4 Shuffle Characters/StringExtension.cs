using System;

namespace ShuffleCharacters
{
    public static class StringExtension
    {
        /// <summary>
        /// Shuffles characters in source string according some rule.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <param name="count">The count of iterations.</param>
        /// <returns>Result string.</returns>
        /// <exception cref="ArgumentNullException">Source string is null.</exception>
        /// <exception cref="ArgumentException">Source string is empty or a white space.</exception>
        /// <exception cref="ArgumentException">Count of iterations is less than 0.</exception>
        public static string ShuffleChars(string? source, int count)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (string.IsNullOrWhiteSpace(source))
            {
                throw new ArgumentException("Source string is empty or a white space.", nameof(source));
            }

            if (count < 0)
            {
                throw new ArgumentException("Count of iterations is less than 0.", nameof(count));
            }

            if (source.Length == 1 || source.Length == 2)
            {
                return source;
            }

            count %= FindModulus(source);

            char[] chars = source.ToCharArray();
            char[] evenChars = new char[chars.Length / 2];
            char[] oddChars = new char[chars.Length - evenChars.Length];
            for (int i = 0; i < count; i++)
            {
                Shuffle(chars, oddChars, evenChars);
            }

            return new string(chars);
        }

        private static int FindModulus(string source)
        {
            char[] chars = source.ToCharArray();
            char[] evenChars = new char[chars.Length / 2];
            char[] oddChars = new char[chars.Length - evenChars.Length];

            int mod = 1;
            chars = Shuffle(chars, oddChars, evenChars);
            while (string.CompareOrdinal(source, new string(chars)) != 0)
            {
                mod++;
                chars = Shuffle(chars, oddChars, evenChars);
            }

            return mod;
        }

        private static char[] Shuffle(char[] chars, char[] oddChars, char[] evenChars)
        {
            for (int j = 0; j < chars.Length; j++)
            {
                if (j % 2 == 0)
                {
                    oddChars[j / 2] = chars[j];
                }
                else
                {
                    evenChars[j / 2] = chars[j];
                }
            }

            Array.Copy(oddChars, 0, chars, 0, oddChars.Length);
            Array.Copy(evenChars, 0, chars, oddChars.Length, evenChars.Length);

            return chars;
        }
    }
}
