namespace WhilePractice
{
    public static class Task3
    {
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
