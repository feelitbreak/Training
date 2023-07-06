using System;
using System.ComponentModel.DataAnnotations;

namespace DependencyInjection.Models
{
    public class Tower
    {
        public int ID { get; set; }

        [Display(Name = "Towers Name")]
        public string Name { get; set; } = string.Empty;

        public int Year { get; set; }
        [Display(Name = "Height (m)")]

        public double Height { get; set; }

        public string Country { get; set; } = string.Empty;
    }
}
