using System;

namespace RecursionIndexOfChar
{
    public static class GetIndexRecursively
    {
        public static int GetIndexOfChar(string? str, char value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str))
            {
                return -1;
            }

            return GetIndexOfChar(str, value, 0);
        }

        public static int GetIndexOfChar(string? str, char value, int startIndex, int count)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str) || count == 0)
            {
                return -1;
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex >= str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater or equals str.Length");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "count is less than zero");
            }

            if (startIndex + count > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > str.Length");
            }

            return GetIndexOfChar(str, value, startIndex, count, startIndex);
        }

        private static int GetIndexOfChar(string str, char value, int i)
        {
            if (i >= str.Length)
            {
                return -1;
            }

            if (str[i] == value)
            {
                return i;
            }

            return GetIndexOfChar(str, value, i + 1);
        }

        private static int GetIndexOfChar(string str, char value, int startIndex, int count, int i)
        {
            if (i >= startIndex + count)
            {
                return -1;
            }

            if (str[i] == value)
            {
                return i;
            }

            return GetIndexOfChar(str, value, startIndex, count, i + 1);
        }
    }
}
