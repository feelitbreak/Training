namespace WhilePractice
{
    public static class Task5
    {
        public static double GetSequenceProduct(int n)
        {
            double prod = 1;
            double i = 1;

            while (i <= n)
            {
                prod *= 1 + (1 / (i * i));
                i++;
            }

            return prod;
        }
    }
}
