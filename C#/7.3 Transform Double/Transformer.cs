using System;
using System.Globalization;

namespace TransformToWords
{
    /// <summary>
    /// Provides transformer methods.
    /// </summary>
    public static class Transformer
    {
        /// <summary>
        /// Converts number's digital representation into words.
        /// </summary>
        /// <param name="number">Number to convert.</param>
        /// <returns>Words representation.</returns>
        public static string TransformToWords(double number)
        {
            if (double.IsNaN(number))
            {
                return "NaN";
            }

            if (double.IsPositiveInfinity(number))
            {
                return "Positive Infinity";
            }

            if (double.IsNegativeInfinity(number))
            {
                return "Negative Infinity";
            }

            if (number == double.Epsilon)
            {
                return "Double Epsilon";
            }

            string numStr = number.ToString(CultureInfo.InvariantCulture);

            LinkedList<string> words = new LinkedList<string>();

            for (int i = 0; i < numStr.Length; i++)
            {
                string word = numStr[i] switch
                {
                    '0' => "zero",
                    '1' => "one",
                    '2' => "two",
                    '3' => "three",
                    '4' => "four",
                    '5' => "five",
                    '6' => "six",
                    '7' => "seven",
                    '8' => "eight",
                    '9' => "nine",
                    'E' => "E",
                    '-' => "minus",
                    '+' => "plus",
                    '.' => "point",
                    _ => "*error*"
                };

                if (i == 0)
                {
                    word = char.ToUpper(word[0], CultureInfo.InvariantCulture) + word.Substring(1);
                }

                words.AddLast(word);
            }

            return string.Join(' ', words);
        }
    }
}
