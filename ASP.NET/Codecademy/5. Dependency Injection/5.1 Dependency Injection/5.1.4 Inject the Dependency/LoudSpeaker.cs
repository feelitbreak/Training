using System;

namespace DependencyInjection
{
    public class LoudSpeaker : ISpeaker
    {
        public void Speak(string message)
        {
            Console.WriteLine(message.ToUpper() + "!");
        }
    }
}
