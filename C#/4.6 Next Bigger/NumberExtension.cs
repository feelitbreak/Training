using System;
using System.Globalization;

namespace NextBiggerTask
{
    public static class NumberExtension
    {
        /// <summary>
        /// Finds the nearest largest integer consisting of the digits of the given positive integer number and null if no such number exists.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>
        /// The nearest largest integer consisting of the digits  of the given positive integer and null if no such number exists.
        /// </returns>
        /// <exception cref="ArgumentException">Thrown when source number is less than 0.</exception>
        public static int? NextBiggerThan(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException($"Value of {nameof(number)} cannot be less than zero.", nameof(number));
            }

            int iLess = -1;
            int digLess = -1;
            int temp = -1;
            int number2 = number;

            for (int i = 0; number2 != 0; i++)
            {
                int mod = number2 % 10;
                if (mod < temp)
                {
                    digLess = mod;
                    iLess = i;
                    break;
                }

                temp = mod;
                number2 /= 10;
            }

            if (iLess == -1)
            {
                return null;
            }

            int digGreaterMin = number % 10;
            int iGreaterMin = 0;
            number2 = number;
            number2 /= 10;
            for (int i = 1; i < iLess; i++)
            {
                int mod = number2 % 10;
                if ((mod > digLess && mod < digGreaterMin) || digGreaterMin <= digLess)
                {
                    digGreaterMin = mod;
                    iGreaterMin = i;
                }

                number2 /= 10;
            }

            number2 = number;
            int rightPart = 0;
            for (int i = 0; i < iGreaterMin; i++)
            {
                rightPart += (number2 % 10) * (int)Math.Pow(10, i);
                number2 /= 10;
            }

            number2 /= 10;
            int middlePart = 0;
            for (int i = iGreaterMin + 1; i < iLess; i++)
            {
                middlePart += (number2 % 10) * (int)Math.Pow(10, i);
                number2 /= 10;
            }

            middlePart += digLess * (int)Math.Pow(10, iGreaterMin);
            rightPart += middlePart;

            int leftPart = number2 / 10;

            long result = leftPart * (int)Math.Pow(10, iLess + 1);
            result += digGreaterMin * (int)Math.Pow(10, iLess);
            char[] charRightPart = rightPart.ToString(CultureInfo.InvariantCulture).ToCharArray();
            Array.Sort(charRightPart);
            result += int.Parse(new string(charRightPart), CultureInfo.InvariantCulture);

            if (result > int.MaxValue)
            {
                return null;
            }
            else
            {
                return (int)result;
            }
        }
    }
}
