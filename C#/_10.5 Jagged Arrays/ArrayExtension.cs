using System;

namespace JaggedArrays
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Orders the rows in a jagged-array by ascending of the sum of the elements in them.
        /// </summary>
        /// <param name="source">The jagged-array to sort.</param>
        /// <exception cref="ArgumentNullException">Thrown when source in null.</exception>
        public static void OrderByAscendingBySum(this int[][]? source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] is not null && source[i].Length != 0)
                {
                    int jMinSum = source.FindIndexOfMinSum(i);
                    (source[i], source[jMinSum]) = (source[jMinSum], source[i]);
                }
            }
        }
        
        /// <summary>
        /// Orders the rows in a jagged-array by descending of the sum of the elements in them.
        /// </summary>
        /// <param name="source">The jagged-array to sort.</param>
        /// <exception cref="ArgumentNullException">Thrown when source in null.</exception>
        public static void OrderByDescendingBySum(this int[][]? source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            for (int i = 0; i < source.Length; i++)
            {
                int jMaxSum = source.FindIndexOfMaxSum(i);
                (source[i], source[jMaxSum]) = (source[jMaxSum], source[i]);
            }
        }
        
        /// <summary>
        /// Orders the rows in a jagged-array by ascending of the max of the elements in them.
        /// </summary>
        /// <param name="source">The jagged-array to sort.</param>
        /// <exception cref="ArgumentNullException">Thrown when source in null.</exception>
        public static void OrderByAscendingByMax(this int[][]? source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] is not null && source[i].Length != 0)
                {
                    int jMinMax = source.FindIndexOfMinMax(i);
                    (source[i], source[jMinMax]) = (source[jMinMax], source[i]);
                }
            }
        }
        
        /// <summary>
        /// Orders the rows in a jagged-array by descending of the max of the elements in them.
        /// </summary>
        /// <param name="source">The jagged-array to sort.</param>
        /// <exception cref="ArgumentNullException">Thrown when source in null.</exception>
        public static void OrderByDescendingByMax(this int[][]? source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            for (int i = 0; i < source.Length; i++)
            {
                int jMaxMax = source.FindIndexOfMaxMax(i);
                (source[i], source[jMaxMax]) = (source[jMaxMax], source[i]);
            }
        }

        private static int FindIndexOfMinSum(this int[][] source, int i)
        {
            int jMinSum = i;
            long minSum = source[jMinSum].FindSum();

            for (int j = jMinSum + 1; j < source.Length; j++)
            {
                if (source[j] is null || source[j].Length == 0)
                {
                    jMinSum = j;
                    break;
                }
                else
                {
                    long sum = source[j].FindSum();
                    if (sum < minSum)
                    {
                        minSum = sum;
                        jMinSum = j;
                    }
                }
            }

            return jMinSum;
        }

        private static int FindIndexOfMaxSum(this int[][] source, int i)
        {
            int jMaxSum = i;
            long? maxSum = (source[jMaxSum] is null || source[jMaxSum].Length == 0) ? null : source[jMaxSum].FindSum();

            for (int j = jMaxSum + 1; j < source.Length; j++)
            {
                if (source[j] is null || source[j].Length == 0)
                {
                    continue;
                }

                long sum = source[j].FindSum();
                if (maxSum is null || sum > maxSum)
                {
                    maxSum = sum;
                    jMaxSum = j;
                }
            }

            return jMaxSum;
        }

        private static int FindIndexOfMinMax(this int[][] source, int i)
        {
            int jMinMax = i;
            int minMax = source[jMinMax].FindMax();

            for (int j = jMinMax + 1; j < source.Length; j++)
            {
                if (source[j] is null || source[j].Length == 0)
                {
                    jMinMax = j;
                    break;
                }
                else
                {
                    int max = source[j].FindMax();
                    if (max < minMax)
                    {
                        minMax = max;
                        jMinMax = j;
                    }
                }
            }

            return jMinMax;
        }

        private static int FindIndexOfMaxMax(this int[][] source, int i)
        {
            int jMaxMax = i;
            int? maxMax = (source[jMaxMax] is null || source[jMaxMax].Length == 0) ? null : source[jMaxMax].FindMax();

            for (int j = jMaxMax + 1; j < source.Length; j++)
            {
                if (source[j] is null || source[j].Length == 0)
                {
                    continue;
                }

                int max = source[j].FindMax();
                if (maxMax is null || max > maxMax)
                {
                    maxMax = max;
                    jMaxMax = j;
                }
            }

            return jMaxMax;
        }

        private static long FindSum(this int[] array)
        {
            long sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        private static int FindMax(this int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }
    }
}
