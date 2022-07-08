using System;

namespace PopulationTask
{
    public static class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0)
            {
                throw new ArgumentException("The initial population cannot be less than or equal 0", nameof(initialPopulation));
            }
            else if (visitors < 0)
            {
                throw new ArgumentException("The count of visitors cannot be less than 0", nameof(visitors));
            }
            else if (currentPopulation <= 0)
            {
                throw new ArgumentException("The current population cannot be less than or equal 0", nameof(currentPopulation));
            }
            else if (currentPopulation < initialPopulation)
            {
                throw new ArgumentException("The current population cannot be less than the initial population");
            }

            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percent));
            }

            int years = 0;
            double population = initialPopulation;

            while (population < currentPopulation)
            {
                population += population * percent * 0.01;
                population += visitors;
                years++;
            }

            return years;
        }
    }
}
