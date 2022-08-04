using System;

namespace LookingForArrayElements
{
    public static class IntegersCounter
    {
        /// <summary>
        /// Searches an array of integers for elements that are in <paramref name="elementsToSearchFor"/> <see cref="Array"/>, and returns the number of occurrences of the elements.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of integers to search.</param>
        /// <param name="elementsToSearchFor">One-dimensional, zero-based <see cref="Array"/> that contains integers to search for.</param>
        /// <returns>The number of occurrences of the elements that are in <paramref name="elementsToSearchFor"/> <see cref="Array"/>.</returns>
        public static int GetIntegersCount(int[]? arrayToSearch, int[]? elementsToSearchFor)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (elementsToSearchFor is null)
            {
                throw new ArgumentNullException(nameof(elementsToSearchFor));
            }

            return GetIntegersCountRecursion(arrayToSearch, elementsToSearchFor, 0, 0);
        }

        /// <summary>
        /// Searches an array of integers for elements that are in <paramref name="elementsToSearchFor"/> <see cref="Array"/>, and returns the number of occurrences of the elements withing the range of elements in the <see cref="Array"/> that starts at the specified index and contains the specified number of elements.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of integers to search.</param>
        /// <param name="elementsToSearchFor">One-dimensional, zero-based <see cref="Array"/> that contains integers to search for.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the elements that are in <paramref name="elementsToSearchFor"/> <see cref="Array"/>.</returns>
        public static int GetIntegersCount(int[]? arrayToSearch, int[]? elementsToSearchFor, int startIndex, int count)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (elementsToSearchFor is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (startIndex < 0 || startIndex >= arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (count < 0 || count > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            return GetIntegersCountRecursion(arrayToSearch, elementsToSearchFor, startIndex, 0, startIndex + count);
        }

        private static int GetIntegersCountRecursion(int[] arrayToSearch, int[] elementsToSearchFor, int i, int j)
        {
            if (i == arrayToSearch.Length)
            {
                return 0;
            }

            if (j == elementsToSearchFor.Length)
            {
                return GetIntegersCountRecursion(arrayToSearch, elementsToSearchFor, i + 1, 0);
            }

            if (arrayToSearch[i] == elementsToSearchFor[j])
            {
                return GetIntegersCountRecursion(arrayToSearch, elementsToSearchFor, i + 1, 0) + 1;
            }

            return GetIntegersCountRecursion(arrayToSearch, elementsToSearchFor, i, j + 1);
        }

        private static int GetIntegersCountRecursion(int[] arrayToSearch, int[] elementsToSearchFor, int i, int j, int limit)
        {
            if (i == limit)
            {
                return 0;
            }

            if (j == elementsToSearchFor.Length)
            {
                return GetIntegersCountRecursion(arrayToSearch, elementsToSearchFor, i + 1, 0, limit);
            }

            if (arrayToSearch[i] == elementsToSearchFor[j])
            {
                return GetIntegersCountRecursion(arrayToSearch, elementsToSearchFor, i + 1, 0, limit) + 1;
            }

            return GetIntegersCountRecursion(arrayToSearch, elementsToSearchFor, i, j + 1, limit);
        }
    }
}
