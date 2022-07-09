using System;

namespace LeapYearTask
{
    public static class Year
    {
        /// <summary>
        /// Report if given year is a leap year.
        /// </summary>
        /// <param name="year">Given year.</param>
        /// <returns>True if given year is leap, false otherwise.</returns>
        public static bool IsLeapYear(int year)
        {
            if (year % 4 != 0)
            {
                return false;
            }
            else if (year % 100 != 0)
            {
                return true;
            }
            else if (year % 400 != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
