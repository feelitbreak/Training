namespace WhilePractice
{
    public static class Task3
    {
        /// <summary>
        /// Calculate the following sum
        /// 1/1^5 + 1/2^5 + 1/3^5 + ... + 1/n^5, where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double SumSequenceElements(int n)
        {
            const int pow = 5;

            double sum = 0;
            double i = 1;

            while (i <= n)
            {
                int j = 0;
                double ipow = 1;

                while (j < pow)
                {
                    ipow *= i;
                    j++;
                }

                sum += 1 / ipow;
                i++;
            }

            return sum;
        }
    }
}
