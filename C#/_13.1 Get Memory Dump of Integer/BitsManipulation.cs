using System;

namespace BinaryRepresentation
{
    public static class BitsManipulation
    {
        /// <summary>
        /// Get binary memory representation of signed long integer.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>Binary memory representation of signed long integer.</returns>
        public static string GetMemoryDumpOf(long number)
        {
            const int bitSize = 64;
            char[] bytes = new char[bitSize];

            long i = 1;
            for (int pos = bytes.Length - 1; pos >= 0; pos--, i = MultiplyByTwo(i))
            {
                if ((number & i) != 0)
                {
                    bytes[pos] = '1';
                }
                else
                {
                    bytes[pos] = '0';
                }
            }

            return new string(bytes);
        }

        private static long MultiplyByTwo(long num)
        {
            return num << 1;
        }
    }
}
