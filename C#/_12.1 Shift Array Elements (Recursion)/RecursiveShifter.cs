using System;

namespace ShiftArrayElements
{
    public static class RecursiveShifter
    {
        /// <summary>
        /// Shifts elements in a <see cref="source"/> array using <see cref="iterations"/> array for getting directions and iterations (odd elements - left direction, even elements - right direction).
        /// </summary>
        /// <param name="source">A source array.</param>
        /// <param name="iterations">An array with iterations.</param>
        /// <returns>An array with shifted elements.</returns>
        /// <exception cref="ArgumentNullException">source array is null.</exception>
        /// <exception cref="ArgumentNullException">iterations array is null.</exception>
        public static int[] Shift(int[]? source, int[]? iterations)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (iterations is null)
            {
                throw new ArgumentNullException(nameof(iterations));
            }

            if (source.Length == 0 || source.Length == 1)
            {
                return source;
            }

            return Shift(source, iterations, 0);
        }

        private static int[] Shift(int[] source, int[] iterations, int i)
        {
            if (i >= iterations.Length)
            {
                return source;
            }

            if (i % 2 == 0)
            {
                int numberOfTimes = iterations[i];
                for (int j = 0; j < numberOfTimes; j++)
                {
                    source.LeftShift();
                }
            }
            else
            {
                int numberOfTimes = iterations[i];
                for (int j = 0; j < numberOfTimes; j++)
                {
                    source.RightShift();
                }
            }

            return Shift(source, iterations, i + 1);
        }

        private static void LeftShift(this int[] source)
        {
            for (int j = 1; j < source.Length; j++)
            {
                (source[j - 1], source[j]) = (source[j], source[j - 1]);
            }
        }

        private static void RightShift(this int[] source)
        {
            for (int j = source.Length - 1; j > 0; j--)
            {
                (source[j - 1], source[j]) = (source[j], source[j - 1]);
            }
        }
    }
}
