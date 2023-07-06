using System;

namespace DependencyInjection
{
    public class Trainer
    {
        private readonly ISpeaker speaker;

        public Trainer()
        {
            speaker = new QuietSpeaker();
        }

        public void BeginTraining()
        {
            speaker.Speak("Time to sweat");
        }
    }
}
