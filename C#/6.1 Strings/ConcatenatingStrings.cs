using System;
using System.Globalization;

namespace Strings
{
    public static class ConcatenatingStrings
    {
        /// <summary>
        /// Concatenates two specified instances of <see cref="string"/>.
        /// </summary>
        public static string ConcatenateStrings(string str0, string str1)
        {
            return string.Concat(str0, str1);
        }

        /// <summary>
        /// Concatenates three specified instances of <see cref="string"/>.
        /// </summary>
        public static string ConcatenateStrings(string str0, string str1, string str2)
        {
            return string.Concat(str0, str1, str2);
        }

        /// <summary>
        /// Concatenates four specified instances of <see cref="string"/>.
        /// </summary>
        public static string ConcatenateStrings(string str0, string str1, string str2, string str3)
        {
            return string.Concat(str0, str1, str2, str3);
        }

        /// <summary>
        /// Concatenates the members of an <see cref="IEnumerable{T}"/> implementation.
        /// </summary>
        public static string ConcatenateStrings(IEnumerable<string> strings)
        {
            return string.Concat(strings);
        }

        /// <summary>
        /// Concatenates the string representations of three specified objects.
        /// </summary>
        public static string ConcatenateValues(string str, int intValue, long longValue)
        {
            return string.Concat(
                str,
                intValue.ToString(CultureInfo.InvariantCulture),
                longValue.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Concatenates the string representations of four specified objects.
        /// </summary>
        public static string ConcatenateValues(short shortValue, float floatValue, bool boolValue, double doubleValue)
        {
            return string.Concat(
                shortValue.ToString(CultureInfo.InvariantCulture),
                floatValue.ToString(CultureInfo.InvariantCulture),
                boolValue.ToString(CultureInfo.InvariantCulture),
                doubleValue.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Concatenates the members of an <see cref="IEnumerable{T}"/> implementation.
        /// </summary>
        public static string ConcatenateValues(IEnumerable<object> values)
        {
            return string.Concat(values);
        }
    }
}
