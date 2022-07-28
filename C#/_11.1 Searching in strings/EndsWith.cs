using System;

namespace SearchingInStrings
{
    public static class EndsWith
    {
        /// <summary>
        /// Determines whether the end of this string instance matches the specified character.
        /// </summary>
        /// <returns>true if the <paramref name="value"/> parameter matches the end of this string; otherwise, false.</returns>
        public static bool IsEndsWith(string str, char value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.EndsWith(value);
        }

        /// <summary>
        /// Determines whether the end of this string instance matches the specified string.
        /// </summary>
        /// <returns>true if the <paramref name="value"/> parameter matches the end of this string; otherwise, false.</returns>
        public static bool IsEndsWith(string str, string value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.EndsWith(value, StringComparison.CurrentCulture);
        }

        /// <summary>
        /// Determines whether the end of this string instance matches the specified string when compared using the specified comparison option.
        /// </summary>
        /// <returns>true if the <paramref name="value"/> parameter matches the end of this string; otherwise, false.</returns>
        public static bool IsEndsWithStringComparison(string str, string value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.EndsWith(value, StringComparison.InvariantCulture);
        }
    }
}
