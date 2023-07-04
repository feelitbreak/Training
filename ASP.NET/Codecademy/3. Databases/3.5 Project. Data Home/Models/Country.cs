using System;
using System.ComponentModel.DataAnnotations;

namespace RazorCountry.Models
{
    public class Country
    {
        public string ID { get; set; } = string.Empty;

        public string ContinentID { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public int? Population { get; set; }

        public int? Area { get; set; }

        public DateTime? UnitedNationsDate { get; set; }
    }
}