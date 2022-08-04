using System;

namespace LookingForArrayElements
{
    public static class DecimalCounter
    {
        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[]? arrayToSearch, decimal[]?[]? ranges)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (ranges is null)
            {
                throw new ArgumentNullException(nameof(ranges));
            }

            for (int k = 0; k < ranges.Length; k++)
            {
                if (ranges[k] is null)
                {
                    throw new ArgumentNullException(nameof(ranges));
                }
                else if (ranges[k]!.Length != 0 && ranges[k]!.Length != 2)
                {
                    throw new ArgumentException("The length of one of the ranges is less or greater than 2 and not empty.");
                }
            }

            return GetDecimalsCountRecursion(arrayToSearch, ranges!, 0, 0);
        }

        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[]? arrayToSearch, decimal[]?[]? ranges, int startIndex, int count)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (ranges is null)
            {
                throw new ArgumentNullException(nameof(ranges));
            }

            for (int k = 0; k < ranges.Length; k++)
            {
                if (ranges[k] is null)
                {
                    throw new ArgumentNullException(nameof(ranges));
                }
                else if (ranges[k]!.Length != 0 && ranges[k]!.Length != 2)
                {
                    throw new ArgumentException("The length of one of the ranges is less or greater than 2 and not empty.");
                }
            }

            if (startIndex < 0 || startIndex >= arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (count < 0 || count > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            return GetDecimalsCountRecursion(arrayToSearch, ranges!, startIndex, 0, startIndex + count);
        }

        private static int GetDecimalsCountRecursion(decimal[] arrayToSearch, decimal[][] ranges, int i, int j)
        {
            if (i == arrayToSearch.Length)
            {
                return 0;
            }

            if (j == ranges.Length)
            {
                return GetDecimalsCountRecursion(arrayToSearch, ranges, i + 1, 0);
            }

            if (ranges[j].Length == 0 || arrayToSearch[i] < ranges[j][0] || arrayToSearch[i] > ranges[j][1])
            {
                return GetDecimalsCountRecursion(arrayToSearch, ranges, i, j + 1);
            }
            else
            {
                return GetDecimalsCountRecursion(arrayToSearch, ranges, i + 1, 0) + 1;
            }
        }

        private static int GetDecimalsCountRecursion(decimal[] arrayToSearch, decimal[][] ranges, int i, int j, int limit)
        {
            if (i == limit)
            {
                return 0;
            }

            if (j == ranges.Length)
            {
                return GetDecimalsCountRecursion(arrayToSearch, ranges, i + 1, 0, limit);
            }

            if (ranges[j].Length == 0 || arrayToSearch[i] < ranges[j][0] || arrayToSearch[i] > ranges[j][1])
            {
                return GetDecimalsCountRecursion(arrayToSearch, ranges, i, j + 1, limit);
            }
            else
            {
                return GetDecimalsCountRecursion(arrayToSearch, ranges, i + 1, 0, limit) + 1;
            }
        }
    }
}
