using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Zoogle.Models;

namespace Zoogle.Pages
{
    public class IndexModel : PageModel
    {
        public ImmutableList<Animal> Animals { get; set; } = ImmutableList<Animal>.Empty;

        public async Task<IActionResult> OnGetAsync()
        {
            Animals = Zoo.Animals;

            // Asynchronous code
            using (StreamWriter writer = new ("log.txt", append: true))
            {
                await writer.WriteLineAsync($"Zoogle visit recorded at {DateTime.Now}.");
            }

            return Page();
        }
    }
}
