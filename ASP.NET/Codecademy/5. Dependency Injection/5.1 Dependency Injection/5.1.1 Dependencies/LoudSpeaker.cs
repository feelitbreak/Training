using System;

namespace DependencyInjection
{
    public class LoudSpeaker
    {
        public void Amplify(string message)
        {
            Console.WriteLine(message.ToUpper() + "!");
        }
    }
}
