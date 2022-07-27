using System;

// ReSharper disable InconsistentNaming
namespace InsertionSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with insertion sort algorithm.
        /// </summary>
        public static void InsertionSort(this int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (int i = 1; i < array.Length; i++)
            {
                InsertElement(array, i);
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive insertion sort algorithm.
        /// </summary>
        public static void RecursiveInsertionSort(this int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            array.RecursiveInsertionSort(1);
        }

        private static void RecursiveInsertionSort(this int[] array, int i)
        {
            if (i >= array.Length)
            {
                return;
            }

            InsertElement(array, i);

            array.RecursiveInsertionSort(i + 1);
        }

        private static void InsertElement(int[] array, int i)
        {
            for (int j = i; j > 0; j--)
            {
                if (array[j - 1] <= array[j])
                {
                    break;
                }

                (array[j - 1], array[j]) = (array[j], array[j - 1]);
            }
        }
    }
}
