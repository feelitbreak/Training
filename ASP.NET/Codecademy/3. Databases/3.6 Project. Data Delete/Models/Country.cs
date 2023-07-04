using System;
using System.ComponentModel.DataAnnotations;

namespace RazorCountry.Models
{
    public class Country
    {
        [Required]
        [StringLength(2, MinimumLength = 2)]
        [RegularExpression(@"[A-Z]+", ErrorMessage = "Only upper case characters are allowed.")]
        [Display(Name = "Code")]
        public string ID { get; set; } = string.Empty;

        public string ContinentID { get; set; } = string.Empty;

        [Required]
        public string Name { get; set; } = string.Empty;

        [Range(1, Int32.MaxValue)]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        public int? Population { get; set; }

        public int? Area { get; set; }

        [Display(Name = "UN Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Range(typeof(DateTime), "24/10/1945", "1/1/2100", ErrorMessage = "The United Nations was created 24/10/1945.")]
        [DataType(DataType.Date)]
        public DateTime? UnitedNationsDate { get; set; }

        public Continent? Continent { get; set; }
    }
}