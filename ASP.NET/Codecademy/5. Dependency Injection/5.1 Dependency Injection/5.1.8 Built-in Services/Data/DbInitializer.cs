using System;
using System.Linq;
using DependencyInjection.Models;

namespace DependencyInjection.Data
{
    public static class DbInitializer
    {
        public static void Initialize(TowerContext context)
        {
            context.Database.EnsureCreated();

            if (context.Towers.Any())
            {
                return;
            }

            var Towers = new Tower[]
            {
        new Tower { Name="Tokyo Skytree", Year=2012, Country="Japan", Height=634 },
        new Tower { Name="Canton Towers", Year=2010, Country="China", Height=604 },
        new Tower { Name="CN Towers", Year=1976, Country="Canada", Height=553.33 },
            };

            foreach (Tower t in Towers)
            {
                context.Towers.Add(t);
            }

            context.SaveChanges();
        }
    }
}
