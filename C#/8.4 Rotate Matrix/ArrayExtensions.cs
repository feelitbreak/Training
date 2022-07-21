using System;

namespace RotateMatrix
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Rotates the image clockwise by 90° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate90DegreesClockwise(this int[,]? matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            int size = matrix.GetLength(0);

            for (int step = 0; step < size / 2; step++)
            {
                for (int i = step; i < size - step - 1; i++)
                {
                    static void SwitchCorners(int[,] matrix, int size, int step, int i)
                    {
                        ref int firstCorner = ref matrix[step, i];
                        ref int secondCorner = ref matrix[i, size - step - 1];
                        ref int thirdCorner = ref matrix[size - step - 1, size - i - 1];
                        ref int fourthCorner = ref matrix[size - i - 1, step];

                        (firstCorner, secondCorner, thirdCorner, fourthCorner) = (fourthCorner, firstCorner, secondCorner, thirdCorner);
                    }

                    SwitchCorners(matrix, size, step, i);
                }
            }
        }

        /// <summary>
        /// Rotates the image counterclockwise by 90° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate90DegreesCounterClockwise(this int[,]? matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            int size = matrix.GetLength(0);

            for (int step = 0; step < size / 2; step++)
            {
                for (int i = step; i < size - step - 1; i++)
                {
                    static void SwitchCorners(int[,] matrix, int size, int step, int i)
                    {
                        ref int firstCorner = ref matrix[step, i];
                        ref int secondCorner = ref matrix[i, size - step - 1];
                        ref int thirdCorner = ref matrix[size - step - 1, size - i - 1];
                        ref int fourthCorner = ref matrix[size - i - 1, step];

                        (firstCorner, secondCorner, thirdCorner, fourthCorner) = (secondCorner, thirdCorner, fourthCorner, firstCorner);
                    }

                    SwitchCorners(matrix, size, step, i);
                }
            }
        }

        /// <summary>
        /// Rotates the image clockwise by 180° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate180DegreesClockwise(this int[,]? matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            int size = matrix.GetLength(0);

            for (int step = 0; step < size / 2; step++)
            {
                for (int i = step; i < size - step - 1; i++)
                {
                    static void SwitchCorners(int[,] matrix, int size, int step, int i)
                    {
                        ref int firstCorner = ref matrix[step, i];
                        ref int secondCorner = ref matrix[i, size - step - 1];
                        ref int thirdCorner = ref matrix[size - step - 1, size - i - 1];
                        ref int fourthCorner = ref matrix[size - i - 1, step];

                        (firstCorner, thirdCorner) = (thirdCorner, firstCorner);
                        (secondCorner, fourthCorner) = (fourthCorner, secondCorner);
                    }

                    SwitchCorners(matrix, size, step, i);
                }
            }
        }

        /// <summary>
        /// Rotates the image counterclockwise by 180° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate180DegreesCounterClockwise(this int[,]? matrix)
        {
            matrix.Rotate180DegreesClockwise();
        }

        /// <summary>
        /// Rotates the image clockwise by 270° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate270DegreesClockwise(this int[,]? matrix)
        {
            matrix.Rotate90DegreesCounterClockwise();
        }

        /// <summary>
        /// Rotates the image counterclockwise by 270° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate270DegreesCounterClockwise(this int[,]? matrix)
        {
            matrix.Rotate90DegreesClockwise();
        }

        /// <summary>
        /// Rotates the image clockwise by 360° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate360DegreesClockwise(this int[,]? matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }
        }

        /// <summary>
        /// Rotates the image counterclockwise by 360° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate360DegreesCounterClockwise(this int[,]? matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }
        }
    }
}
