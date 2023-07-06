using System;

namespace DependencyInjection
{
    public class Trainer
    {
        private readonly LoudSpeaker speaker;

        public Trainer()
        {
            speaker = new LoudSpeaker();
        }

        public void BeginTraining()
        {
            speaker.Amplify("Time to sweat");
        }
    }
}
