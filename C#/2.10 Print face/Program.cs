namespace PrintFace
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("  Hello, world! ");
        }

        public static void SayHelloUser(string userName)
        {
            Console.WriteLine($"Hello, {userName}!");
        }

        public static void PrintFace()
        {
            Console.WriteLine($" +\"\"\"\"\"+{Environment.NewLine}(| o o |){Environment.NewLine}" +
                $" |  ^  |{Environment.NewLine} | '-' |{Environment.NewLine} +-----+");
        }
    }
}
