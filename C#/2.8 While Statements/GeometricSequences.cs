namespace WhileStatements
{
    public static class GeometricSequences
    {
        public static uint SumGeometricSequenceTerms1(uint a, uint r, uint n)
        {
            uint sum = 0;
            int i = 0;

            while (i < n)
            {
                int j = 0;
                uint rpow = 1;

                while (j < i)
                {
                    rpow *= r;
                    j++;
                }

                sum += a * rpow;
                i++;
            }

            return sum;
        }

        public static uint SumGeometricSequenceTerms2(uint n)
        {
            const uint firstTerm = 13;
            const uint commonRatio = 3;

            return SumGeometricSequenceTerms1(firstTerm, commonRatio, n);
        }

        public static uint CountGeometricSequenceTerms3(uint a, uint r, uint maxTerm)
        {
            uint count = 0;
            uint term = a;

            while (term <= maxTerm)
            {
                count++;
                term *= r;
            }

            return count;
        }

        public static uint CountGeometricSequenceTerms4(uint a, uint r, uint n, uint minTerm)
        {
            uint count = 0;
            int i = 0;
            uint term = a;

            while (i < n)
            {
                if (term >= minTerm)
                {
                    count++;
                }

                term *= r;
                i++;
            }

            return count;
        }
    }
}
