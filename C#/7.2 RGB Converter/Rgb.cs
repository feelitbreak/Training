using System;
using System.Globalization;

namespace RgbConverter
{
    public static class Rgb
    {
        /// <summary>
        /// Gets hexadecimal representation source RGB decimal values.
        /// </summary>
        /// <param name="red">The valid decimal value for RGB is in the range 0-255.</param>
        /// <param name="green">The valid decimal value for RGB is in the range 0-255.</param>
        /// <param name="blue">The valid decimal value for RGB is in the range 0-255.</param>
        /// <returns>Returns hexadecimal representation source RGB decimal values.</returns>
        public static string GetHexRepresentation(int red, int green, int blue)
        {
            if (red < 0)
            {
                red = 0;
            }
            else if (red > 255)
            {
                red = 255;
            }

            if (green < 0)
            {
                green = 0;
            }
            else if (green > 255)
            {
                green = 255;
            }

            if (blue < 0)
            {
                blue = 0;
            }
            else if (blue > 255)
            {
                blue = 255;
            }

            string redString = red.ToString("X2", CultureInfo.InvariantCulture);
            string greenString = green.ToString("X2", CultureInfo.InvariantCulture);
            string blueString = blue.ToString("X2", CultureInfo.InvariantCulture);

            return string.Concat(redString, greenString, blueString);
        }
    }
}
