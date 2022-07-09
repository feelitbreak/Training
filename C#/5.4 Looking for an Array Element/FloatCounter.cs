﻿using System;

namespace LookingForArrayElements
{
    public static class FloatCounter
    {
        /// <summary>
        /// Searches an array of floats for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="rangeStart">One-dimensional, zero-based <see cref="Array"/> of the range starts.</param>
        /// <param name="rangeEnd">One-dimensional, zero-based <see cref="Array"/> of the range ends.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetFloatsCount(float[]? arrayToSearch, float[]? rangeStart, float[]? rangeEnd)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (rangeStart is null)
            {
                throw new ArgumentNullException(nameof(rangeStart));
            }

            if (rangeEnd is null)
            {
                throw new ArgumentNullException(nameof(rangeEnd));
            }

            if (rangeStart.Length != rangeEnd.Length)
            {
                throw new ArgumentException("Arrays of range starts and range ends can't contain a different number of elements.");
            }

            for (int i = 0; i < rangeStart.Length; i++)
            {
                if (rangeStart[i] > rangeEnd[i])
                {
                    throw new ArgumentException("Range start value can't be greater than the range end value.");
                }
            }

            int sum = 0;
            for (int i = 0; i < rangeStart.Length; i++)
            {
                for (int j = 0; j < arrayToSearch.Length; j++)
                {
                    if (arrayToSearch[j] >= rangeStart[i] && arrayToSearch[j] <= rangeEnd[i])
                    {
                        sum++;
                    }
                }
            }

            return sum;
        }

        /// <summary>
        /// Searches an array of floats for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="rangeStart">One-dimensional, zero-based <see cref="Array"/> of the range starts.</param>
        /// <param name="rangeEnd">One-dimensional, zero-based <see cref="Array"/> of the range ends.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetFloatsCount(float[]? arrayToSearch, float[]? rangeStart, float[]? rangeEnd, int startIndex, int count)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (rangeStart is null)
            {
                throw new ArgumentNullException(nameof(rangeStart));
            }

            if (rangeEnd is null)
            {
                throw new ArgumentNullException(nameof(rangeEnd));
            }

            if (rangeStart.Length != rangeEnd.Length)
            {
                throw new ArgumentException("Arrays of range starts and range ends can't contain a different number of elements.");
            }

            for (int k = 0; k < rangeStart.Length; k++)
            {
                if (rangeStart[k] > rangeEnd[k])
                {
                    throw new ArgumentException("Range start value can't be greater than the range end value.");
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

            if (rangeStart.Length == 0 || count == 0)
            {
                return 0;
            }

            int sum = 0;
            int i = 0;
            do
            {
                int j = startIndex;
                do
                {
                    if (arrayToSearch[j] >= rangeStart[i] && arrayToSearch[j] <= rangeEnd[i])
                    {
                        sum++;
                    }

                    j++;
                }
                while (j < startIndex + count && j < arrayToSearch.Length);
            }
            while (++i < rangeStart.Length);

            return sum;
        }
    }
}
