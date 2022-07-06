using System;

namespace Calculations
{
    public static class Calculator
    {
        public static double GetSumOne(int n)
        {
            double sum = 0;

            for (double i = 1; i <= n; i++)
            {
                sum += 1 / i;
            }

            return sum;
        }

        public static double GetSumTwo(int n)
        {
            double sum = 0;

            for (double i = 1, j = 1; i <= n; i++, j *= -1)
            {
                sum += j / (i * (i + 1));
            }

            return sum;
        }

        public static double GetSumThree(int n)
        {
            const double pow = 5;
            double sum = 0;

            for (double i = 1; i <= n; i++)
            {
                sum += 1 / Math.Pow(i, pow);
            }

            return sum;
        }

        public static double GetSumFour(int n)
        {
            double sum = 0;

            for (double i = 3; i <= (2 * n) + 1; i += 2)
            {
                sum += 1 / (i * i);
            }

            return sum;
        }

        public static double GetProductOne(int n)
        {
            double prod = 1;

            for (double i = 1; i <= n; i++)
            {
                prod *= 1 + (1 / (i * i));
            }

            return prod;
        }

        public static double GetSumFive(int n)
        {
            double sum = 0;

            for (double i = 3, j = -1; i <= (2 * n) + 1; i += 2, j *= -1)
            {
                sum += j / i;
            }

            return sum;
        }

        public static double GetSumSix(int n)
        {
            double sum = 0;
            double numenator = 1;
            double denominator = 0;

            for (double i = 1; i <= n; i++)
            {
                numenator *= i;
                denominator += 1 / i;
                sum += numenator / denominator;
            }

            return sum;
        }

        public static double GetSumSeven(int n)
        {
            double sum = 0;

            for (double i = 0; i < n; i++)
            {
                sum = Math.Sqrt(2 + sum);
            }

            return sum;
        }

        public static double GetSumEight(int n)
        {
            double sum = 0;
            double denominator = 0;

            for (double i = 1; i <= n; i++)
            {
                double angle = (Math.PI * i) / 180.0;
                denominator += Math.Sin(angle);
                sum += 1 / denominator;
            }

            return sum;
        }
    }
}
