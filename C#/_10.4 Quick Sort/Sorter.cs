using System;

// ReSharper disable InconsistentNaming
namespace QuickSort
{
    public static class Sorter
    {
        private static readonly Random Rand = new ();

        /// <summary>
        /// Sorts an <paramref name="array"/> with quick sort algorithm.
        /// </summary>
        public static void QuickSort(this int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            int l = 0;
            int r = array.Length - 1;

            int[] lRStack = new int[array.Length];
            int top = 0;

            lRStack.Push(ref top, l, r);

            while (top > 0)
            {
                l = lRStack[--top];
                r = lRStack[--top];

                int i = l;
                int j = r;
                array.Partition(ref i, ref j);
                lRStack.Push(ref top, i, r);
                lRStack.Push(ref top, l, j);
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive quick sort algorithm.
        /// </summary>
        public static void RecursiveQuickSort(this int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length > 1)
            {
                array.RecursiveQuickSort(0, array.Length - 1);
            }
        }

        private static void RecursiveQuickSort(this int[] array, int l, int r)
        {
            int i = l;
            int j = r;
            array.Partition(ref i, ref j);

            if (l < j)
            {
                array.RecursiveQuickSort(l, j);
            }

            if (i < r)
            {
                array.RecursiveQuickSort(i, r);
            }
        }

        private static void Partition(this int[] array, ref int i, ref int j)
        {
            int x = array[Rand.Next(j - i) + i];
            do
            {
                while (array[i] < x)
                {
                    i++;
                }

                while (array[j] > x)
                {
                    j--;
                }

                if (i <= j)
                {
                    if (i < j)
                    {
                        (array[i], array[j]) = (array[j], array[i]);
                    }

                    i++;
                    j--;
                }
            }
            while (i <= j);
        }

        private static void Push(this int[] stack, ref int top, int l, int r)
        {
            if (l < r)
            {
                stack[top++] = r;
                stack[top++] = l;
            }
        }
    }
}
