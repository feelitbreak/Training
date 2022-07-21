using System;
using System.Globalization;

namespace TransformerToWords
{
    /// <summary>
    /// Implements transformer class.
    /// </summary>
    public class Transformer
    {
        private string[]? strings;

        public Transformer()
        {
            this.strings = null;
        }

        /// <summary>
        /// Transforms each element of source array into its 'word format'.
        /// </summary>
        /// <param name="source">Source array.</param>
        /// <returns>Array of 'word format' of elements of source array.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        /// <example>
        /// new[] { 2.345, -0.0d, 0.0d, 0.1d } => { "Two point three four five", "Minus zero", "Zero", "Zero point one" }.
        /// </example>
        public string[] Transform(double[]? source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("Array is empty.", nameof(source));
            }

            this.strings = new string[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                this.TransformToWords(source[i], i);
            }

            return this.strings;
        }

        private void TransformToWords(double number, int i)
        {
            if (double.IsNaN(number))
            {
                this.strings![i] = "Not a Number";
                return;
            }

            if (double.IsPositiveInfinity(number))
            {
                this.strings![i] = "Positive Infinity";
                return;
            }

            if (double.IsNegativeInfinity(number))
            {
                this.strings![i] = "Negative Infinity";
                return;
            }

            if (number == double.Epsilon)
            {
                this.strings![i] = "Double Epsilon";
                return;
            }

            string numStr = number.ToString(CultureInfo.InvariantCulture);

            LinkedList<string> words = new LinkedList<string>();

            for (int j = 0; j < numStr.Length; j++)
            {
                string word = numStr[j] switch
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

                if (j == 0)
                {
                    word = char.ToUpper(word[0], CultureInfo.InvariantCulture) + word[1..];
                }

                words.AddLast(word);
            }

            this.strings![i] = string.Join(' ', words);
        }
    }
}
