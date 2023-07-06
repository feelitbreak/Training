using System;

namespace DependencyInjection
{
    public class Trainer
    {
        private readonly ISpeaker _speaker;

        public Trainer(ISpeaker speaker)
        {
            _speaker = speaker;
        }

        public void BeginTraining()
        {
            _speaker.Speak("Time to sweat");
        }
    }
}
