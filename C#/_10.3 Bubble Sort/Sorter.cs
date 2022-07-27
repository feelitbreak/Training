using System;

// ReSharper disable InconsistentNaming
namespace BubbleSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with bubble sort algorithm.
        /// </summary>
        public static void BubbleSort(this int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                array.SwapUntil(array.Length - i);
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive bubble sort algorithm.
        /// </summary>
        public static void RecursiveBubbleSort(this int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            array.RecursiveBubbleSort(0);
        }

        private static void RecursiveBubbleSort(this int[] array, int i)
        {
            if (i >= array.Length - 1)
            {
                return;
            }

            array.SwapUntil(array.Length - i);

            array.RecursiveBubbleSort(i + 1);
        }

        private static void SwapUntil(this int[] array, int limit)
        {
            for (int j = 1; j < limit; j++)
            {
                if (array[j - 1] > array[j])
                {
                    (array[j - 1], array[j]) = (array[j], array[j - 1]);
                }
            }
        }
    }
}
