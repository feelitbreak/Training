using System;

namespace SpiralMatrix
{
    /// <summary>
    /// Matrix manipulation.
    /// </summary>
    public static class MatrixExtension
    {
        /// <summary>
        /// Fills the matrix with natural numbers, starting from 1 in the top-left corner, increasing in an inward, clockwise spiral order.
        /// </summary>
        /// <param name="size">Matrix size.</param>
        /// <returns>Filled matrix.</returns>
        /// <exception cref="ArgumentException">Thrown when matrix size less or equal zero.</exception>
        /// <example> size = 3
        ///     1 2 3
        ///     8 9 4
        ///     7 6 5.
        /// </example>
        /// <example> size = 4
        ///     1  2  3  4
        ///     12 13 14 5
        ///     11 16 15 6
        ///     10 9  8  7.
        /// </example>
        public static int[,] GetMatrix(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Matrix size is less or equal to zero.", nameof(size));
            }

            int[,] matrix = new int[size, size];
            int num = 1;

            for (int step = 0; step < Math.Ceiling((double)size / 2); step++)
            {
                FillBorders(matrix, size, step, ref num);
            }

            return matrix;
        }

        private static void FillBorders(int[,] matrix, int size, int step, ref int num)
        {
            FillUp(matrix, size, step, ref num);
            FillRight(matrix, size, step, ref num);
            FillDown(matrix, size, step, ref num);
            FillLeft(matrix, size, step, ref num);
        }

        private static void FillUp(int[,] matrix, int size, int step, ref int num)
        {
            for (int j = step; j < size - step; j++)
            {
                matrix[step, j] = num;
                num++;
            }
        }

        private static void FillRight(int[,] matrix, int size, int step, ref int num)
        {
            for (int i = step + 1; i < size - step; i++)
            {
                matrix[i, size - step - 1] = num;
                num++;
            }
        }

        private static void FillDown(int[,] matrix, int size, int step, ref int num)
        {
            for (int j = size - step - 2; j >= step; j--)
            {
                matrix[size - step - 1, j] = num;
                num++;
            }
        }

        private static void FillLeft(int[,] matrix, int size, int step, ref int num)
        {
            for (int i = size - step - 2; i >= step + 1; i--)
            {
                matrix[i, step] = num;
                num++;
            }
        }
    }
}
