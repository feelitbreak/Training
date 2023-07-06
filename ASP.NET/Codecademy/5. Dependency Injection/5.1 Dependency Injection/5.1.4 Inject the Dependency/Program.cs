using System;

namespace DependencyInjection
{
    public static class Program
    {
        static void Main()
        {
            Console.WriteLine("Using trainer:");
            Trainer trainer = new (new LoudSpeaker());
            trainer.BeginTraining();
        }
    }
}
