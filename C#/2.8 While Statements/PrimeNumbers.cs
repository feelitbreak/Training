namespace WhileStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            if (n == 0 || n == 1)
            {
                return false;
            }

            uint i = 2;

            while (i <= n / 2)
            {
                if (n % i == 0)
                {
                    return false;
                }

                i++;
            }

            return true;
        }

        public static uint GetLastPrimeNumber(uint n)
        {
            uint i = 2;
            uint answer = 0;

            while (i <= n)
            {
                if (IsPrimeNumber(i))
                {
                    answer = i;
                }

                i++;
            }

            return answer;
        }

        public static uint SumLastPrimeNumbers(uint n, uint count)
        {
            uint i = n;
            uint sum = 0;
            uint j = 0;

            while (i >= 2 && j < count)
            {
                if (IsPrimeNumber(i))
                {
                    sum += i;
                    j++;
                }

                i--;
            }

            return sum;
        }
    }
}
