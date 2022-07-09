using System;

namespace DartsGame
{
    public static class Darts
    {
        /// <summary>
        /// Calculates the earned points in a single toss of a Darts game.
        /// </summary>
        /// <param name="x">x-coordinate of dart.</param>
        /// <param name="y">y-coordinate of dart.</param>
        /// <returns>The earned points.</returns>
        public static int GetScore(double x, double y)
        {
            return (x, y) switch
            {
                { } when (x * x) + (y * y) <= 1 => 10,
                { } when (x * x) + (y * y) <= 25 => 5,
                { } when (x * x) + (y * y) <= 100 => 1,
                _ => 0
            };
        }
    }
}
