namespace WhilePractice
{
    public static class Task6
    {
        /// <summary>
        /// Calculate the following product
        /// (1 + 1/(1 * 1)) * (1 + 1/(2 * 2)) * (1 + 1/(3 * 3)) * ... * (1 + 1/(n * n)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Product of elements.</returns>
        public static double SumSequenceElements(int n)
        {
            double sum = 0;
            double i = 3;

            while (i <= (2 * n) + 1)
            {
                double term = 1 / i;

                if ((i + 1) % 4 == 0)
                {
                    term *= -1;
                }

                sum += term;
                i += 2;
            }

            return sum;
        }
    }
}
