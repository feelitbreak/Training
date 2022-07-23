using System;

namespace RelocationElements
{
    /// <summary>
    /// Class for operations with array.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Moves all of the elements with set value to the end, preserving the order of the other elements.
        /// </summary>
        /// <param name="source"> Source array. </param>
        /// <param name="value">Source value.</param>
        /// <exception cref="ArgumentNullException">Thrown when source array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when source array is empty.</exception>
        public static void MoveToTail(int[]? source, int value)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("Array is empty", nameof(source));
            }

            int iOfFirstValue = 0;
            for (; iOfFirstValue < source.Length; iOfFirstValue++)
            {
                if (source[iOfFirstValue] == value)
                {
                    break;
                }
            }

            for (int i = iOfFirstValue + 1; i < source.Length; i++)
            {
                if (source[i] != value)
                {
                    (source[iOfFirstValue], source[i]) = (source[i], source[iOfFirstValue]);
                    iOfFirstValue++;
                }
            }
        }
    }
}
