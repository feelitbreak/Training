using System;

namespace Gcd
{
    public static class IntegerExtensions
    {
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

        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b)
        {
            System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
            int result = GetGcdByEuclidean(a, b);
            watch.Stop();
            elapsedTicks = watch.ElapsedTicks;
            return result;
        }

        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, int c)
        {
            System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
            int result = GetGcdByEuclidean(a, b, c);
            watch.Stop();
            elapsedTicks = watch.ElapsedTicks;
            return result;
        }

        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, params int[] other)
        {
            System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
            int result = GetGcdByEuclidean(a, b, other);
            watch.Stop();
            elapsedTicks = watch.ElapsedTicks;
            return result;
        }

        public static int GetGcdByStein(out long elapsedTicks, int a, int b)
        {
            System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
            int result = GetGcdByStein(a, b);
            watch.Stop();
            elapsedTicks = watch.ElapsedTicks;
            return result;
        }

        public static int GetGcdByStein(out long elapsedTicks, int a, int b, int c)
        {
            System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
            int result = GetGcdByStein(a, b, c);
            watch.Stop();
            elapsedTicks = watch.ElapsedTicks;
            return result;
        }

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
