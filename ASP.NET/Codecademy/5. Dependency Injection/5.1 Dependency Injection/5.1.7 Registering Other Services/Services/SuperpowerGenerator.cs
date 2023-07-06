using System;

namespace DependencyInjection.Services
{
    public class SuperpowerGenerator : IStringGenerator
    {
        private readonly Random rand = new ();
        private readonly string[] powers = new string[]
        {
      "Regenerative Healing 💗",
      "Replication 👯‍♂️",
      "Invisibility 👻",
      "Wallcrawling 🕷",
      "Prehensile Tail 🐒",
      "Sonic Scream 😱",
      "Aquatic Breathing 🐡",
      "X-Ray Vision 🤓",
        };

        public string Generate()
        {
            return powers[rand.Next(powers.Length)];
        }
    }
}
