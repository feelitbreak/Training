using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace RazorCountry.Models
{
    public class Continent
    {
        [Required, StringLength(2, MinimumLength = 2), Display(Name = "Code")]
        [RegularExpression(@"[A-Z]+", ErrorMessage = "Only upper case characters are allowed.")]
        public string ID { get; set; } = string.Empty;

        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<Country>? Countries { get; set; }
    }
}