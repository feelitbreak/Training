using System;

namespace Gcd
{
    /// <summary>
    /// Provide methods with integers.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.");
            }

            if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number cannot be {int.MinValue}.");
            }
            else if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b), $"Number cannot be {int.MinValue}.");
            }

            if (a == 0)
            {
                return Math.Abs(b);
            }
            else if (b == 0)
            {
                return Math.Abs(a);
            }

            while (b != 0)
            {
                (a, b) = (b, a % b);
            }

            return Math.Abs(a);
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b, int c)
        {
            if (a == 0 && b == 0)
            {
                return GetGcdByEuclidean(a, GetGcdByEuclidean(b, c));
            }
            else
            {
                return GetGcdByEuclidean(GetGcdByEuclidean(a, b), c);
            }
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b, params int[] other)
        {
            int iNonZero = -1;

            for (int i = 0; i < other.Length; i++)
            {
                if (other[i] != 0)
                {
                    iNonZero = i;
                    break;
                }
            }

            int gcd;

            if (iNonZero == -1)
            {
                gcd = GetGcdByEuclidean(a, b);
            }
            else
            {
                gcd = GetGcdByEuclidean(a, b, other[iNonZero]);
            }

            for (int i = 0; i < other.Length; i++)
            {
                if (i != iNonZero)
                {
                    gcd = GetGcdByEuclidean(gcd, other[i]);
                }
            }

            return gcd;
        }

        /// <summary>
        /// Calculates GCD of two integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.");
            }

            if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number cannot be {int.MinValue}.");
            }
            else if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b), $"Number cannot be {int.MinValue}.");
            }

            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a == 0)
            {
                return b;
            }
            else if (b == 0)
            {
                return a;
            }

            int d = 0;

            while (a != b)
            {
                if (a % 2 == 0 && b % 2 == 0)
                {
                    a /= 2;
                    b /= 2;
                    d++;
                }
                else if (a % 2 == 1 && b % 2 == 0)
                {
                    b /= 2;
                }
                else if (a % 2 == 0 && b % 2 == 1)
                {
                    a /= 2;
                }
                else
                {
                    if (a < b)
                    {
                        (a, b) = (b, a);
                    }

                    a = (a - b) / 2;
                }
            }

            return (int)(a * Math.Pow(2, d));
        }

        /// <summary>
        /// Calculates GCD of three integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b, int c)
        {
            if (a == 0 && b == 0)
            {
                return GetGcdByStein(a, GetGcdByStein(b, c));
            }
            else
            {
                return GetGcdByStein(GetGcdByStein(a, b), c);
            }
        }

        /// <summary>
        /// Calculates the GCD of integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b, params int[] other)
        {
            int iNonZero = -1;

            for (int i = 0; i < other.Length; i++)
            {
                if (other[i] != 0)
                {
                    iNonZero = i;
                    break;
                }
            }

            int gcd;

            if (iNonZero == -1)
            {
                gcd = GetGcdByStein(a, b);
            }
            else
            {
                gcd = GetGcdByStein(a, b, other[iNonZero]);
            }

            for (int i = 0; i < other.Length; i++)
            {
                if (i != iNonZero)
                {
                    gcd = GetGcdByStein(gcd, other[i]);
                }
            }

            return gcd;
        }

        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b)
        {
            System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
            int result = GetGcdByEuclidean(a, b);
            watch.Stop();
            elapsedTicks = watch.ElapsedTicks;
            return result;
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, int c)
        {
            System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
            int result = GetGcdByEuclidean(a, b, c);
            watch.Stop();
            elapsedTicks = watch.ElapsedTicks;
            return result;
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in Ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, params int[] other)
        {
            System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
            int result = GetGcdByEuclidean(a, b, other);
            watch.Stop();
            elapsedTicks = watch.ElapsedTicks;
            return result;
        }

        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long elapsedTicks, int a, int b)
        {
            System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
            int result = GetGcdByStein(a, b);
            watch.Stop();
            elapsedTicks = watch.ElapsedTicks;
            return result;
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long elapsedTicks, int a, int b, int c)
        {
            System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
            int result = GetGcdByStein(a, b, c);
            watch.Stop();
            elapsedTicks = watch.ElapsedTicks;
            return result;
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in Ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long elapsedTicks, int a, int b, params int[] other)
        {
            System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
            int result = GetGcdByStein(a, b, other);
            watch.Stop();
            elapsedTicks = watch.ElapsedTicks;
            return result;
        }
    }
}
