namespace WhilePractice
{
    public static class Task2
    {
        public static double SumSequenceElements(int n)
        {
            double sum = 0;
            double i = 1;

            while (i <= n)
            {
                double term = 1 / (i * (i + 1));

                if (i % 2 == 0)
                {
                    term *= -1;
                }

                sum += term;
                i++;
            }

            return sum;
        }
    }
}
