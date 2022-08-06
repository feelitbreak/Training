using System;

namespace FindMaximumTask
{
    /// <summary>
    /// Class for operations with array.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Finds the element of the array with the maximum value recursively.
        /// </summary>
        /// <param name="array"> Source array. </param>
        /// <returns>The element of the array with the maximum value.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        public static int FindMaximum(int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty", nameof(array));
            }

            if (array.Length == 1)
            {
                return array[0];
            }

            return FindMaximum(array, 0, array.Length - 1);
        }

        private static int FindMaximum(int[] array, int left, int right)
        {
            if (right - left <= 1)
            {
                return Math.Max(array[left], array[right]);
            }

            int m = GetMean(left, right);
            int leftMax = FindMaximum(array, left, m);
            int rightMax = FindMaximum(array, m + 1, right);
            return Math.Max(leftMax, rightMax);
        }

        private static int GetMean(int a, int b)
        {
            return a + ((b - a) / 2);
        }
    }
}
