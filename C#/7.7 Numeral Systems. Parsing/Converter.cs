using System;

namespace NumeralSystems
{
    /// <summary>
    /// Converts a string representations of a numbers to its integer equivalent.
    /// </summary>
    public static class Converter
    {
        /// <summary>
        /// Converts the string representation of a positive number in the octal numeral system to its 32-bit signed integer equivalent.
        /// </summary>
        /// <param name="source">The string representation of a positive number in the octal numeral system.</param>
        /// <returns>A positive decimal value.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if source string presents a negative number
        /// - or
        /// contains invalid symbols (non-octal alphabetic characters).
        /// Valid octal alphabetic characters: 0,1,2,3,4,5,6,7.
        /// </exception>
        public static int ParsePositiveFromOctal(this string source)
        {
            const int octBase = 8;
            uint result = source.ParseFromBase(octBase);

            if (result > int.MaxValue)
            {
                throw new ArgumentException("Source string presents a negative number", nameof(source));
            }
            else
            {
                return (int)result;
            }
        }

        /// <summary>
        /// Converts the string representation of a positive number in the decimal numeral system to its 32-bit signed integer equivalent.
        /// </summary>
        /// <param name="source">The string representation of a positive number in the decimal numeral system.</param>
        /// <returns>A positive decimal value.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if source string presents a negative number
        /// - or
        /// contains invalid symbols (non-decimal alphabetic characters).
        /// Valid decimal alphabetic characters: 0,1,2,3,4,5,6,7,8,9.
        /// </exception>
        public static int ParsePositiveFromDecimal(this string source)
        {
            const int decBase = 10;
            uint result = source.ParseFromBase(decBase);

            if (result > int.MaxValue)
            {
                throw new ArgumentException("Source string presents a negative number", nameof(source));
            }
            else
            {
                return (int)result;
            }
        }

        /// <summary>
        /// Converts the string representation of a positive number in the hex numeral system to its 32-bit signed integer equivalent.
        /// </summary>
        /// <param name="source">The string representation of a positive number in the hex numeral system.</param>
        /// <returns>A positive decimal value.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if source string presents a negative number
        /// - or
        /// contains invalid symbols (non-hex alphabetic characters).
        /// Valid hex alphabetic characters: 0,1,2,3,4,5,6,7,8,9,A(or a),B(or b),C(or c),D(or d),E(or e),F(or f).
        /// </exception>
        public static int ParsePositiveFromHex(this string source)
        {
            const int hexBase = 16;
            uint result = source.ParseFromBase(hexBase);

            if (result > int.MaxValue)
            {
                throw new ArgumentException("Source string presents a negative number", nameof(source));
            }
            else
            {
                return (int)result;
            }
        }

        /// <summary>
        /// Converts the string representation of a positive number in the octal, decimal or hex numeral system to its 32-bit signed integer equivalent.
        /// </summary>
        /// <param name="source">The string representation of a positive number in the the octal, decimal or hex numeral system.</param>
        /// <param name="radix">The radix.</param>
        /// <returns>A positive decimal value.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if source string presents a negative number
        /// - or
        /// contains invalid for given numeral system symbols
        /// -or-
        /// the radix is not equal 8, 10 or 16.
        /// </exception>
        public static int ParsePositiveByRadix(this string source, int radix)
        {
            if (radix == 8)
            {
                return source.ParsePositiveFromOctal();
            }
            else if (radix == 10)
            {
                return source.ParsePositiveFromDecimal();
            }
            else if (radix == 16)
            {
                return source.ParsePositiveFromHex();
            }
            else
            {
                throw new ArgumentException("The radix is not equal 8, 10 or 16.", nameof(radix));
            }
        }

        /// <summary>
        /// Converts the string representation of a signed number in the octal, decimal or hex numeral system to its 32-bit signed integer equivalent.
        /// </summary>
        /// <param name="source">The string representation of a signed number in the the octal, decimal or hex numeral system.</param>
        /// <param name="radix">The radix.</param>
        /// <returns>A signed decimal value.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if source contains invalid for given numeral system symbols
        /// -or-
        /// the radix is not equal 8, 10 or 16.
        /// </exception>
        public static int ParseByRadix(this string source, int radix)
        {
            if (radix == 8)
            {
                return (int)source.ParseFromBase(8);
            }
            else if (radix == 10)
            {
                if (!string.IsNullOrEmpty(source) && source[0] == '-')
                {
                    return -source[1..].ParsePositiveFromDecimal();
                }
                else
                {
                    return source.ParsePositiveFromDecimal();
                }
            }
            else if (radix == 16)
            {
                return (int)source.ParseFromBase(16);
            }
            else
            {
                throw new ArgumentException("The radix is not equal 8, 10 or 16.", nameof(radix));
            }
        }

        /// <summary>
        /// Converts the string representation of a positive number in the octal numeral system to its 32-bit signed integer equivalent.
        /// A return value indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="source">The string representation of a positive number in the octal numeral system.</param>
        /// <param name="value">A positive decimal value.</param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        public static bool TryParsePositiveFromOctal(this string source, out int value)
        {
            try
            {
                value = source.ParsePositiveFromOctal();
                return true;
            }
            catch (ArgumentException)
            {
                value = 0;
                return false;
            }
        }

        /// <summary>
        /// Converts the string representation of a positive number in the decimal numeral system to its 32-bit signed integer equivalent.
        /// A return value indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="source">The string representation of a positive number in the decimal numeral system.</param>
        /// <returns>A positive decimal value.</returns>
        /// <param name="value">A positive decimal value.</param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        public static bool TryParsePositiveFromDecimal(this string source, out int value)
        {
            try
            {
                value = source.ParsePositiveFromDecimal();
                return true;
            }
            catch (ArgumentException)
            {
                value = 0;
                return false;
            }
        }

        /// <summary>
        /// Converts the string representation of a positive number in the hex numeral system to its 32-bit signed integer equivalent.
        /// A return value indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="source">The string representation of a positive number in the hex numeral system.</param>
        /// <returns>A positive decimal value.</returns>
        /// <param name="value">A positive decimal value.</param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        public static bool TryParsePositiveFromHex(this string source, out int value)
        {
            try
            {
                value = source.ParsePositiveFromHex();
                return true;
            }
            catch (ArgumentException)
            {
                value = 0;
                return false;
            }
        }

        /// <summary>
        /// Converts the string representation of a positive number in the octal, decimal or hex numeral system to its 32-bit signed integer equivalent.
        /// A return value indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="source">The string representation of a positive number in the the octal, decimal or hex numeral system.</param>
        /// <param name="radix">The radix.</param>
        /// <returns>A positive decimal value.</returns>
        /// <param name="value">A positive decimal value.</param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        /// <exception cref="ArgumentException">Thrown the radix is not equal 8, 10 or 16.</exception>
        public static bool TryParsePositiveByRadix(this string source, int radix, out int value)
        {
            try
            {
                value = source.ParsePositiveByRadix(radix);
                return true;
            }
            catch (ArgumentException e)
            {
                if (e.ParamName != nameof(radix))
                {
                    value = 0;
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Converts the string representation of a signed number in the octal, decimal or hex numeral system to its 32-bit signed integer equivalent.
        /// A return value indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="source">The string representation of a signed number in the the octal, decimal or hex numeral system.</param>
        /// <param name="radix">The radix.</param>
        /// <returns>A positive decimal value.</returns>
        /// <param name="value">A positive decimal value.</param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        /// <exception cref="ArgumentException">Thrown the radix is not equal 8, 10 or 16.</exception>
        public static bool TryParseByRadix(this string source, int radix, out int value)
        {
            try
            {
                value = source.ParseByRadix(radix);
                return true;
            }
            catch (ArgumentException e)
            {
                if (e.ParamName != nameof(radix))
                {
                    value = 0;
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        private static uint ParseFromBase(this string source, int radix)
        {
            uint result = 0;

            for (int i = 0; i < source.Length; i++)
            {
                if (radix == 8 && (source[^(i + 1)] < '0' || source[^(i + 1)] > '7'))
                {
                    throw new ArgumentException(
                        "The source string contains invalid symbols (non-octal alphabetic characters)",
                        nameof(source));
                }

                if (radix == 10 && (source[^(i + 1)] < '0' || source[^(i + 1)] > '9'))
                {
                    throw new ArgumentException(
                        "The source string contains invalid symbols (non-decimal alphabetic characters)",
                        nameof(source));
                }

                result += (uint)Math.Pow(radix, i) * source[^(i + 1)] switch
                {
                    '0' => 0u,
                    '1' => 1u,
                    '2' => 2u,
                    '3' => 3u,
                    '4' => 4u,
                    '5' => 5u,
                    '6' => 6u,
                    '7' => 7u,
                    '8' => 8u,
                    '9' => 9u,
                    'A' or 'a' => 10u,
                    'B' or 'b' => 11u,
                    'C' or 'c' => 12u,
                    'D' or 'd' => 13u,
                    'E' or 'e' => 14u,
                    'F' or 'f' => 15u,
                    _ => throw new ArgumentException(
                        "The source string contains invalid symbols (non-hex alphabetic characters)",
                        nameof(source))
                };
            }

            return result;
        }
    }
}
