using System;
using System.Globalization;

namespace LouVuiDateCode
{
    public static class DateCodeParser
    {
        /// <summary>
        /// Parses a date code and returns a <see cref="manufacturingYear"/> and <see cref="manufacturingMonth"/>.
        /// </summary>
        /// <param name="dateCode">A three or four number date code.</param>
        /// <param name="manufacturingYear">A manufacturing year to return.</param>
        /// <param name="manufacturingMonth">A manufacturing month to return.</param>
        public static void ParseEarly1980Code(string dateCode, out uint manufacturingYear, out uint manufacturingMonth)
        {
            if (string.IsNullOrEmpty(dateCode))
            {
                throw new ArgumentNullException(nameof(dateCode));
            }

            if (dateCode.Length < 3)
            {
                throw new ArgumentException("The date code is invalid.", nameof(dateCode));
            }

            try
            {
                const string century = "19";
                manufacturingYear = uint.Parse(string.Concat(century, dateCode[..2]), CultureInfo.InvariantCulture);

                manufacturingMonth = uint.Parse(dateCode[2..], CultureInfo.InvariantCulture);
            }
            catch
            {
                throw new ArgumentException("The date code is invalid.", nameof(dateCode));
            }

            if (manufacturingYear < 1980 || manufacturingYear > 1989)
            {
                throw new ArgumentException("The date code is invalid.", nameof(dateCode));
            }

            if (manufacturingMonth < 1 || manufacturingMonth > 12)
            {
                throw new ArgumentException("The date code is invalid.", nameof(dateCode));
            }
        }

        /// <summary>
        /// Parses a date code and returns a <paramref name="factoryLocationCode"/>, <paramref name="manufacturingYear"/>, <paramref name="manufacturingMonth"/> and <paramref name="factoryLocationCountry"/> array.
        /// </summary>
        /// <param name="dateCode">A three or four number date code.</param>
        /// <param name="factoryLocationCountry">A factory location country array.</param>
        /// <param name="factoryLocationCode">A factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year to return.</param>
        /// <param name="manufacturingMonth">A manufacturing month to return.</param>
        public static void ParseLate1980Code(string dateCode, out Country[] factoryLocationCountry, out string factoryLocationCode, out uint manufacturingYear, out uint manufacturingMonth)
        {
            if (string.IsNullOrEmpty(dateCode))
            {
                throw new ArgumentNullException(nameof(dateCode));
            }

            if (dateCode.Length < 5 || dateCode.Length > 7)
            {
                throw new ArgumentException("The date code is invalid.", nameof(dateCode));
            }

            try
            {
                const string century = "19";
                manufacturingYear = uint.Parse(string.Concat(century, dateCode[..2]), CultureInfo.InvariantCulture);

                manufacturingMonth = uint.Parse(dateCode[2..^2], CultureInfo.InvariantCulture);
            }
            catch
            {
                throw new ArgumentException("The date code is invalid.", nameof(dateCode));
            }

            factoryLocationCode = dateCode[^2..];

            factoryLocationCountry = CountryParser.GetCountry(factoryLocationCode);

            if (factoryLocationCountry.Length == 0)
            {
                throw new ArgumentException("The date code is invalid.", nameof(dateCode));
            }

            if (manufacturingYear < 1980 || manufacturingYear > 1989)
            {
                throw new ArgumentException("The date code is invalid.", nameof(dateCode));
            }

            if (manufacturingMonth < 1 || manufacturingMonth > 12)
            {
                throw new ArgumentException("The date code is invalid.", nameof(dateCode));
            }
        }

        /// <summary>
        /// Parses a date code and returns a <paramref name="factoryLocationCode"/>, <paramref name="manufacturingYear"/>, <paramref name="manufacturingMonth"/> and <paramref name="factoryLocationCountry"/> array.
        /// </summary>
        /// <param name="dateCode">A six number date code.</param>
        /// <param name="factoryLocationCountry">A factory location country array.</param>
        /// <param name="factoryLocationCode">A factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year to return.</param>
        /// <param name="manufacturingMonth">A manufacturing month to return.</param>
        public static void Parse1990Code(string dateCode, out Country[] factoryLocationCountry, out string factoryLocationCode, out uint manufacturingYear, out uint manufacturingMonth)
        {
            if (string.IsNullOrEmpty(dateCode))
            {
                throw new ArgumentNullException(nameof(dateCode));
            }

            if (dateCode.Length < 6 || dateCode.Length > 7)
            {
                throw new ArgumentException("The date code is invalid.", nameof(dateCode));
            }

            factoryLocationCode = dateCode[..^4];

            factoryLocationCountry = CountryParser.GetCountry(factoryLocationCode);

            try
            {
                if (dateCode[^4] == '0')
                {
                    manufacturingMonth = uint.Parse(dateCode[^2..^1], CultureInfo.InvariantCulture);
                }
                else
                {
                    manufacturingMonth = uint.Parse(string.Concat(dateCode[^4..^3], dateCode[^2..^1]), CultureInfo.InvariantCulture);
                }

                const string century1 = "19";
                const string century2 = "20";
                if (dateCode[^3] == '9')
                {
                    manufacturingYear = uint.Parse(
                        string.Concat(century1, dateCode[^3..^2], dateCode[^1..]),
                        CultureInfo.InvariantCulture);
                }
                else
                {
                    manufacturingYear = uint.Parse(
                        string.Concat(century2, dateCode[^3..^2], dateCode[^1..]),
                        CultureInfo.InvariantCulture);
                }
            }
            catch
            {
                throw new ArgumentException("The date code is invalid.", nameof(dateCode));
            }

            if (factoryLocationCountry.Length == 0)
            {
                throw new ArgumentException("The date code is invalid.", nameof(dateCode));
            }

            if (manufacturingYear < 1990 || manufacturingYear > 2006)
            {
                throw new ArgumentException("The date code is invalid.", nameof(dateCode));
            }

            if (manufacturingMonth < 1 || manufacturingMonth > 12)
            {
                throw new ArgumentException("The date code is invalid.", nameof(dateCode));
            }
        }

        /// <summary>
        /// Parses a date code and returns a <paramref name="factoryLocationCode"/>, <paramref name="manufacturingYear"/>, <paramref name="manufacturingWeek"/> and <paramref name="factoryLocationCountry"/> array.
        /// </summary>
        /// <param name="dateCode">A six number date code.</param>
        /// <param name="factoryLocationCountry">A factory location country array.</param>
        /// <param name="factoryLocationCode">A factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year to return.</param>
        /// <param name="manufacturingWeek">A manufacturing week to return.</param>
        public static void Parse2007Code(string dateCode, out Country[] factoryLocationCountry, out string factoryLocationCode, out uint manufacturingYear, out uint manufacturingWeek)
        {
            if (string.IsNullOrEmpty(dateCode))
            {
                throw new ArgumentNullException(nameof(dateCode));
            }

            if (dateCode.Length < 6 || dateCode.Length > 7)
            {
                throw new ArgumentException("The date code is invalid.", nameof(dateCode));
            }

            factoryLocationCode = dateCode[..^4];

            factoryLocationCountry = CountryParser.GetCountry(factoryLocationCode);

            try
            {
                if (dateCode[^4] == '0')
                {
                    manufacturingWeek = uint.Parse(dateCode[^2..^1], CultureInfo.InvariantCulture);
                }
                else
                {
                    manufacturingWeek = uint.Parse(string.Concat(dateCode[^4..^3], dateCode[^2..^1]), CultureInfo.InvariantCulture);
                }

                const string century = "20";
                manufacturingYear = uint.Parse(
                        string.Concat(century, dateCode[^3..^2], dateCode[^1..]),
                        CultureInfo.InvariantCulture);
            }
            catch
            {
                throw new ArgumentException("The date code is invalid.", nameof(dateCode));
            }

            if (factoryLocationCountry.Length == 0)
            {
                throw new ArgumentException("The date code is invalid.", nameof(dateCode));
            }

            if (manufacturingYear < 2007 || manufacturingYear > DateTime.Now.Year)
            {
                throw new ArgumentException("The date code is invalid.", nameof(dateCode));
            }

            if (manufacturingWeek < 1 || manufacturingWeek > DateCodeGenerator.WeeksInAYear((int)manufacturingYear))
            {
                throw new ArgumentException("The date code is invalid.", nameof(dateCode));
            }
        }
    }
}
