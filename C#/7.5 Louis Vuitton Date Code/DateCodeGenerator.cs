using System;
using System.Globalization;

namespace LouVuiDateCode
{
    public static class DateCodeGenerator
    {
        /// <summary>
        /// Generates a date code using rules from early 1980s.
        /// </summary>
        /// <param name="manufacturingYear">A manufacturing year.</param>
        /// <param name="manufacturingMonth">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string GenerateEarly1980Code(uint manufacturingYear, uint manufacturingMonth)
        {
            if (manufacturingYear < 1980 || manufacturingYear > 1989)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingYear));
            }

            if (manufacturingMonth < 1 || manufacturingMonth > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingMonth));
            }

            return string.Concat(
                manufacturingYear.ToString(CultureInfo.InvariantCulture)[2..],
                manufacturingMonth.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Generates a date code using rules from early 1980s.
        /// </summary>
        /// <param name="manufacturingDate">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string GenerateEarly1980Code(DateTime manufacturingDate)
        {
            return GenerateEarly1980Code((uint)manufacturingDate.Year, (uint)manufacturingDate.Month);
        }

        /// <summary>
        /// Generates a date code using rules from late 1980s.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year.</param>
        /// <param name="manufacturingMonth">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string GenerateLate1980Code(string factoryLocationCode, uint manufacturingYear, uint manufacturingMonth)
        {
            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            if (manufacturingYear < 1980 || manufacturingYear > 1989)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingYear));
            }

            if (manufacturingMonth < 1 || manufacturingMonth > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingMonth));
            }

            if (!IsProbablyAFactoryLocation(factoryLocationCode))
            {
                throw new ArgumentException("The factory location code is invalid.", nameof(factoryLocationCode));
            }

            return string.Concat(
                manufacturingYear.ToString(CultureInfo.InvariantCulture)[2..],
                manufacturingMonth.ToString(CultureInfo.InvariantCulture),
                factoryLocationCode.ToUpper(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Generates a date code using rules from late 1980s.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingDate">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string GenerateLate1980Code(string factoryLocationCode, DateTime manufacturingDate)
        {
            return GenerateLate1980Code(factoryLocationCode, (uint)manufacturingDate.Year, (uint)manufacturingDate.Month);
        }

        /// <summary>
        /// Generates a date code using rules from 1990 to 2006 period.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year.</param>
        /// <param name="manufacturingMonth">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string Generate1990Code(string factoryLocationCode, uint manufacturingYear, uint manufacturingMonth)
        {
            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            if (manufacturingYear < 1990 || manufacturingYear > 2006)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingYear));
            }

            if (manufacturingMonth < 1 || manufacturingMonth > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingMonth));
            }

            if (!IsProbablyAFactoryLocation(factoryLocationCode))
            {
                throw new ArgumentException("The factory location code is invalid.", nameof(factoryLocationCode));
            }

            string month = manufacturingMonth.ToString(CultureInfo.InvariantCulture);

            if (month.Length == 1)
            {
                month = string.Concat("0", month);
            }

            string year = manufacturingYear.ToString(CultureInfo.InvariantCulture);

            return string.Concat(
                factoryLocationCode.ToUpper(CultureInfo.InvariantCulture),
                month[0],
                year[2],
                month[1],
                year[3]);
        }

        /// <summary>
        /// Generates a date code using rules from 1990 to 2006 period.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingDate">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string Generate1990Code(string factoryLocationCode, DateTime manufacturingDate)
        {
            return Generate1990Code(factoryLocationCode, (uint)manufacturingDate.Year, (uint)manufacturingDate.Month);
        }

        /// <summary>
        /// Generates a date code using rules from post 2007 period.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year.</param>
        /// <param name="manufacturingWeek">A manufacturing week number.</param>
        /// <returns>A generated date code.</returns>
        public static string Generate2007Code(string factoryLocationCode, uint manufacturingYear, uint manufacturingWeek)
        {
            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            if (manufacturingYear < 2007 || manufacturingYear > DateTime.Now.Year)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingYear));
            }

            if (manufacturingWeek < 1 || manufacturingWeek > WeeksInAYear((int)manufacturingYear))
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingYear));
            }

            if (!IsProbablyAFactoryLocation(factoryLocationCode))
            {
                throw new ArgumentException("The factory location code is invalid.", nameof(factoryLocationCode));
            }

            string week = manufacturingWeek.ToString(CultureInfo.InvariantCulture);

            if (week.Length == 1)
            {
                week = string.Concat("0", week);
            }

            string year = manufacturingYear.ToString(CultureInfo.InvariantCulture);

            return string.Concat(
                factoryLocationCode.ToUpper(CultureInfo.InvariantCulture),
                week[0],
                year[2],
                week[1],
                year[3]);
        }

        /// <summary>
        /// Generates a date code using rules from post 2007 period.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingDate">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string Generate2007Code(string factoryLocationCode, DateTime manufacturingDate)
        {
            return Generate2007Code(factoryLocationCode, (uint)ISOWeek.GetYear(manufacturingDate), (uint)ISOWeek.GetWeekOfYear(manufacturingDate));
        }

        public static int WeeksInAYear(int year)
        {
            DateTime firstDay = new DateTime(year, 1, 1);

            if ((DateTime.IsLeapYear(year) && firstDay.DayOfWeek == DayOfWeek.Wednesday) ||
                (!DateTime.IsLeapYear(year) && firstDay.DayOfWeek == DayOfWeek.Thursday))
            {
                return 53;
            }
            else
            {
                return 52;
            }
        }

        private static bool IsProbablyAFactoryLocation(string code)
        {
            if (code.Length > 2 && code != "AAS")
            {
                return false;
            }

            if (code.Length <= 1)
            {
                return false;
            }

            if (code == "A0" || code == "A1" || code == "A2" || code == "a0" || code == "a1" || code == "a2")
            {
                return true;
            }

            static bool IsEnglishLetter(char c)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (IsEnglishLetter(code[0]) && IsEnglishLetter(code[1]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
