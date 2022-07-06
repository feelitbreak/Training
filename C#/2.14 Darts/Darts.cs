namespace DartsGame
{
    public static class Darts
    {
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
