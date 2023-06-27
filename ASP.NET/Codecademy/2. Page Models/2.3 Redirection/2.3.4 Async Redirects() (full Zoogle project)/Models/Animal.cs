using System;
using System.Collections.Generic;

namespace Zoogle.Models
{
    public class Animal
    {
        public string CommonName { get; set; }

        public string Species { get; set; }

        public string Description { get; set; }

        public IEnumerable<string> Habitats { get; set; }

        public string GroupName { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public string ImageUrl { get; set; }

        public Animal(string commonName, string species, string description, IEnumerable<string> habitats, string groupName, double height, double weight, string imageUrl)
        {
            CommonName = commonName;
            Species = species;
            Description = description;
            Habitats = habitats;
            GroupName = groupName;
            Height = height;
            Weight = weight;
            ImageUrl = imageUrl;
        }
    }
}
