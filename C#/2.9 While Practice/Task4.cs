namespace WhilePractice
{
    public static class Task4
    {
        public static double SumSequenceElements(int n)
        {
            double sum = 0;
            double i = 3;

            while (i <= (2 * n) + 1)
            {
                sum += 1 / (i * i);
                i += 2;
            }

            return sum;
        }
    }
}
