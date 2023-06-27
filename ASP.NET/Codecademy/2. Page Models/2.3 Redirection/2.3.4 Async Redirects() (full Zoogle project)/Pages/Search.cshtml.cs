using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zoogle.Models;

namespace Zoogle.Pages
{
    public class SearchModel : PageModel
    {
        public ImmutableList<Animal> Animals { get; set; } = ImmutableList<Animal>.Empty;
        public Animal? FoundAnimal { get; set; }
        public string SearchString { get; set; } = string.Empty;

#nullable enable
        public IActionResult OnGet(string? searchString)
        {
            Animals = Zoo.Animals;

            if (!string.IsNullOrEmpty(searchString))
            {
                if (string.Equals(searchString, "all", StringComparison.OrdinalIgnoreCase))
                {
                    return RedirectToPage("/Index");
                }

                FoundAnimal = Animals
                    .FirstOrDefault(a => a.CommonName == searchString);
            }

            return Page();
        }
    }
}