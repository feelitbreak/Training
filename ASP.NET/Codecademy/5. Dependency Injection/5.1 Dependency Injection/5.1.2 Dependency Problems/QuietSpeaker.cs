using System;

namespace DependencyInjection
{
    public class QuietSpeaker : ISpeaker
    {
        public void Speak(string message)
        {
            Console.WriteLine("..." + message.ToLower() + "...");
        }
    }
}
