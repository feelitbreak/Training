using System;

namespace LookingForChars
{
    public static class CharsCounter
    {
        /// <summary>
        /// Searches a string for all characters that are in <see cref="Array" />, and returns the number of occurrences of all characters.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <returns>The number of occurrences of all characters.</returns>
        public static int GetCharsCount(string? str, char[]? chars)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (chars is null)
            {
                throw new ArgumentNullException(nameof(chars));
            }

            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    if (str[i] == chars[j])
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        /// <summary>
        /// Searches a string for all characters that are in <see cref="Array" />, and returns the number of occurrences of all characters within the range of elements in the <see cref="string"/> that starts at the specified index and ends at the specified index.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <param name="startIndex">A zero-based starting index of the search.</param>
        /// <param name="endIndex">A zero-based ending index of the search.</param>
        /// <returns>The number of occurrences of all characters within the specified range of elements in the <see cref="string"/>.</returns>
        public static int GetCharsCount(string? str, char[]? chars, int startIndex, int endIndex)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (chars is null)
            {
                throw new ArgumentNullException(nameof(chars));
            }

            if (startIndex < 0 || startIndex >= str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (endIndex < 0 || endIndex >= str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex));
            }

            if (startIndex > endIndex)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            int count = 0;
            int i = startIndex;
            while (i < endIndex + 1)
            {
                int j = 0;
                while (j < chars.Length)
                {
                    if (str[i] == chars[j])
                    {
                        count++;
                    }

                    j++;
                }

                i++;
            }

            return count;
        }

        /// <summary>
        /// Searches a string for a limited number of characters that are in <see cref="Array" />, and returns the number of occurrences of all characters within the range of elements in the <see cref="string"/> that starts at the specified index and ends at the specified index.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <param name="startIndex">A zero-based starting index of the search.</param>
        /// <param name="endIndex">A zero-based ending index of the search.</param>
        /// <param name="limit">A maximum number of characters to search.</param>
        /// <returns>The limited number of occurrences of characters to search for within the specified range of elements in the <see cref="string"/>.</returns>
        public static int GetCharsCount(string? str, char[]? chars, int startIndex, int endIndex, int limit)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (chars is null)
            {
                throw new ArgumentNullException(nameof(chars));
            }

            if (startIndex < 0 || startIndex >= str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (endIndex < 0 || endIndex >= str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex));
            }

            if (startIndex > endIndex)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (limit < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(limit));
            }

            if (limit == 0)
            {
                return 0;
            }

            if (chars.Length == 0)
            {
                return 0;
            }

            int count = 0;
            int i = startIndex;
            do
            {
                int j = 0;
                do
                {
                    if (str[i] == chars[j])
                    {
                        count++;
                    }

                    j++;
                }
                while (j < chars.Length && count < limit);

                i++;
            }
            while (i < endIndex + 1 && count < limit);

            return count;
        }
    }
}
