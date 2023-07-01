using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCountry.Models;
using RazorCountry.Data;

namespace RazorCountry.Pages.Continents
{
    public class IndexModel : PageModel
    {
        private readonly CountryContext _context;

        public IndexModel(CountryContext context)
        {
            _context = context;
        }

        public List<Continent> Continents { get; set; } = new ();

        public async Task OnGetAsync()
        {
            Continents = await _context.Continents.ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }
            else
            {
                Continent? continent = await _context.Continents.FindAsync(id);

                if (continent is not null)
                {
                    _context.Continents.Remove(continent);
                    await _context.SaveChangesAsync();
                }

                return RedirectToPage("./Index");
            }
        }
    }
}