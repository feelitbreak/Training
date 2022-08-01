using System;

namespace ShiftArrayElements
{
    public static class RecursiveEnumShifter
    {
        /// <summary>
        /// Shifts elements in a <see cref="source"/> array using directions from <see cref="directions"/> array, one element shift per each direction array element.
        /// </summary>
        /// <param name="source">A source array.</param>
        /// <param name="directions">An array with directions.</param>
        /// <returns>An array with shifted elements.</returns>
        /// <exception cref="ArgumentNullException">source array is null.</exception>
        /// <exception cref="ArgumentNullException">directions array is null.</exception>
        /// <exception cref="InvalidOperationException">direction array contains an element that is not <see cref="Direction.Left"/> or <see cref="Direction.Right"/>.</exception>
        public static int[] Shift(int[]? source, Direction[]? directions)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (directions is null)
            {
                throw new ArgumentNullException(nameof(directions));
            }

            return Shift(source, directions, 0);
        }

        private static int[] Shift(int[] source, Direction[] directions, int i)
        {
            if (i >= directions.Length)
            {
                return source;
            }

            switch (directions[i])
            {
                case Direction.Left:
                    {
                        source.LeftShift();
                        break;
                    }

                case Direction.Right:
                    {
                        source.RightShift();
                        break;
                    }

                default:
                    throw new InvalidOperationException($"Incorrect {directions[i]} enum value.");
            }

            return Shift(source, directions, i + 1);
        }

        private static void LeftShift(this int[] source)
        {
            int firstElem = source[0];
            Array.Copy(source, 1, source, 0, source.Length - 1);
            source[^1] = firstElem;
        }

        private static void RightShift(this int[] source)
        {
            int lastElem = source[^1];
            Array.Copy(source, 0, source, 1, source.Length - 1);
            source[0] = lastElem;
        }
    }
}
