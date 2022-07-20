using System;
using System.Globalization;

namespace NumeralSystems
{
    public static class Converter
    {
        /// <summary>
        /// Gets the value of a positive integer to its equivalent string representation in the octal numeral systems.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>The equivalent string representation of the number in the octal numeral systems.</returns>
        /// <exception cref="ArgumentException">Thrown if number is less than zero.</exception>
        public static string GetPositiveOctal(this int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("The number is less than zero.", nameof(number));
            }

            return GetOctal((uint)number);
        }

        /// <summary>
        /// Gets the value of a positive integer to its equivalent string representation in the decimal numeral systems.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>The equivalent string representation of the number in the decimal numeral systems.</returns>
        /// <exception cref="ArgumentException">Thrown if number is less than zero.</exception>
        public static string GetPositiveDecimal(this int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("The number is less than zero.", nameof(number));
            }

            if (number == 0)
            {
                return "0";
            }

            const int decBase = 10;
            List<char> digits = new List<char>();
            while (number > 0)
            {
                digits.Add((char)((number % decBase) + '0'));
                number /= decBase;
            }

            digits.Reverse();
            return new string(digits.ToArray());
        }

        /// <summary>
        /// Gets the value of a positive integer to its equivalent string representation in the hexadecimal numeral systems.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>The equivalent string representation of the number in the hexadecimal numeral systems.</returns>
        /// <exception cref="ArgumentException">Thrown if number is less than zero.</exception>
        public static string GetPositiveHex(this int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("The number is less than zero.", nameof(number));
            }

            return GetHex((uint)number);
        }

        /// <summary>
        /// Gets the value of a positive integer to its equivalent string representation in a specified radix.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <param name="radix">Base of the numeral systems.</param>
        /// <returns>The equivalent string representation of the number in a specified radix.</returns>
        /// <exception cref="ArgumentException">Thrown if radix is not equal 8, 10 or 16.</exception>
        /// <exception cref="ArgumentException">Thrown if number is less than zero.</exception>
        public static string GetPositiveRadix(this int number, int radix)
        {
            if (radix == 8)
            {
                return GetPositiveOctal(number);
            }
            else if (radix == 10)
            {
                return GetPositiveDecimal(number);
            }
            else if (radix == 16)
            {
                return GetPositiveHex(number);
            }
            else
            {
                throw new ArgumentException("The radix isn't equal to 8, 10, or 16.", nameof(radix));
            }
        }

        /// <summary>
        /// Gets the value of a signed integer to its equivalent string representation in a specified radix.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <param name="radix">Base of the numeral systems.</param>
        /// <returns>The equivalent string representation of the number in a specified radix.</returns>
        /// <exception cref="ArgumentException">Thrown if radix is not equal 8, 10 or 16.</exception>
        public static string GetRadix(this int number, int radix)
        {
            if (radix == 8)
            {
                return GetOctal((uint)number);
            }
            else if (radix == 10)
            {
                if (number < 0)
                {
                    return "-" + GetPositiveDecimal(-number);
                }
                else
                {
                    return GetPositiveDecimal(number);
                }
            }
            else if (radix == 16)
            {
                return GetHex((uint)number);
            }
            else
            {
                throw new ArgumentException("The radix isn't equal to 8, 10, or 16.", nameof(radix));
            }
        }

        private static string GetOctal(uint number)
        {
            if (number == 0)
            {
                return "0";
            }

            const uint octalBase = 8;
            List<char> digits = new List<char>();
            while (number > 0)
            {
                digits.Add((char)((number % octalBase) + '0'));
                number /= octalBase;
            }

            digits.Reverse();
            return new string(digits.ToArray());
        }

        private static string GetHex(uint number)
        {
            if (number == 0)
            {
                return "0";
            }

            const uint hexBase = 16;
            List<string> digits = new List<string>();
            while (number > 0)
            {
                digits.Add((number % hexBase) switch
                {
                    0 => "0",
                    1 => "1",
                    2 => "2",
                    3 => "3",
                    4 => "4",
                    5 => "5",
                    6 => "6",
                    7 => "7",
                    8 => "8",
                    9 => "9",
                    10 => "A",
                    11 => "B",
                    12 => "C",
                    13 => "D",
                    14 => "E",
                    _ => "F"
                });

                number /= hexBase;
            }

            digits.Reverse();
            return string.Concat(digits);
        }
    }
}
