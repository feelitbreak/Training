using System;

namespace Numbers
{
    public static class IntegerExtensions
    {
        /// <summary>
        /// Obtains formalized information in the form of an enum <see cref="ComparisonSigns"/>
        /// about the relationship of the order of two adjacent digits for all digits of a given number.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>Information in the form of an enum <see cref="ComparisonSigns"/>
        /// about the relationship of the order of two adjacent digits for all digits of a given number
        /// or null if the information is not defined.</returns>
        public static ComparisonSigns? GetTypeComparisonSigns(this long number)
        {
            if (number.IsOneDigit())
            {
                return null;
            }

            int firstNeighbour = (int)(number % 10);
            number /= 10;
            int secondNeighbour;

            ComparisonSigns result = 0;
            while (number != 0)
            {
                secondNeighbour = (int)(number % 10);
                number /= 10;
                result.CheckNeighbours(firstNeighbour, secondNeighbour);
                firstNeighbour = secondNeighbour;
            }

            return result;
        }

        /// <summary>
        /// Gets information in the form of a string about the type of sequence that the digit of a given number represents.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>The information in the form of a string about the type of sequence that the digit of a given number represents.</returns>
        public static string GetTypeOfDigitsSequence(this long number)
        {
            return number.GetTypeComparisonSigns() switch
            {
                null => "One digit number.",
                ComparisonSigns.LessThan => "Strictly Increasing.",
                ComparisonSigns.MoreThan => "Strictly Decreasing.",
                ComparisonSigns.Equals => "Monotonous.",
                ComparisonSigns.LessThan | ComparisonSigns.Equals => "Increasing.",
                ComparisonSigns.MoreThan | ComparisonSigns.Equals => "Decreasing.",
                _ => "Unordered."
            };
        }

        private static bool IsOneDigit(this long number)
        {
            const int lastDigit = 9;
            return number >= -lastDigit && number <= lastDigit;
        }

        private static void CheckNeighbours(this ref ComparisonSigns result, int firstNeighbour, int secondNeighbour)
        {
            if (secondNeighbour < firstNeighbour)
            {
                result |= ComparisonSigns.LessThan;
            }
            else if (secondNeighbour > firstNeighbour)
            {
                result |= ComparisonSigns.MoreThan;
            }
            else
            {
                result |= ComparisonSigns.Equals;
            }
        }
    }
}
