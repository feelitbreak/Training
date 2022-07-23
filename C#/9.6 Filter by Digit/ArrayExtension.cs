using System;
using System.Globalization;

namespace FilterTask
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Returns new array of elements that contain expected digit from source array.
        /// </summary>
        /// <param name="source">Source array.</param>
        /// <param name="digit">Expected digit.</param>
        /// <returns>Array of elements that contain expected digit.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when digit value is out of range (0..9).</exception>
        /// <example>
        /// {1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17}  => { 7, 70, 17 } for digit = 7.
        /// </example>
        public static int[] FilterByDigit(int[]? source, int digit)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("Array is empty", nameof(source));
            }

            if (digit < 0 || digit > 9)
            {
                throw new ArgumentOutOfRangeException(nameof(digit));
            }

            List<int> result = new List<int>();
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i].ContainsDigit(digit))
                {
                    result.Add(source[i]);
                }
            }

            return result.ToArray();
        }

        private static bool ContainsDigit(this int number, int digit)
        {
            if (number == 0)
            {
                return digit == 0;
            }

            number = Math.Abs(number);

            const int digitDivisor = 10;
            while (number > 0)
            {
                if (number % digitDivisor == digit)
                {
                    return true;
                }

                number /= digitDivisor;
            }

            return false;
        }
    }
}
