using System;

namespace ArithmeticSequenceTask
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            if (count <= 0)
            {
                throw new ArgumentException("The count of elements of the sequence cannot be less or equals zero.", nameof(count));
            }

            if ((number == int.MaxValue && add > 0) || (number == int.MinValue && add < 0))
            {
                throw new OverflowException("The count of elements of the sequence cannot be less or equals zero.");
            }

            int sum = number;
            int i = 1;

            while (i < count)
            {
                sum += number + (i * add);
                i++;
            }

            return sum;
        }
    }
}
