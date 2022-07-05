namespace WhileStatements
{
    public static class QuadraticSequences
    {
        public static long SumQuadraticSequenceTerms1(long a, long b, long c, long maxTerm)
        {
            long sum = 0;
            int i = 1;
            long term = 0;

            while (term <= maxTerm)
            {
                sum += term;
                term = (a * i * i) + (b * i) + c;
                i++;
            }

            return sum;
        }

        public static long SumQuadraticSequenceTerms2(long a, long b, long c, long startN, long count)
        {
            long sum = 0;
            long i = startN;

            while (i < startN + count)
            {
                sum += (a * i * i) + (b * i) + c;
                i++;
            }

            return sum;
        }
    }
}
