using System;

// ReSharper disable InconsistentNaming
namespace SelectionSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with selection sort algorithm.
        /// </summary>
        public static void SelectionSort(this int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (int i = 0; i < array.Length; i++)
            {
                int jMin = FindIndexOfMin(array, i);
                (array[i], array[jMin]) = (array[jMin], array[i]);
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive selection sort algorithm.
        /// </summary>
        public static void RecursiveSelectionSort(this int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            array.RecursiveSelectionSort(0);
        }

        private static void RecursiveSelectionSort(this int[] array, int i)
        {
            if (i == array.Length)
            {
                return;
            }

            int jMin = FindIndexOfMin(array, i);
            (array[i], array[jMin]) = (array[jMin], array[i]);

            array.RecursiveSelectionSort(i + 1);
        }

        private static int FindIndexOfMin(int[] array, int i)
        {
            int jMin = i;
            for (int j = i; j < array.Length; j++)
            {
                if (array[j] < array[jMin])
                {
                    jMin = j;
                }
            }

            return jMin;
        }
    }
}
