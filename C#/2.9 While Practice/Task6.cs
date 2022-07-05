namespace WhilePractice
{
    public static class Task6
    {
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
