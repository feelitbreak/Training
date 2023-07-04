using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCountry.Models;
using RazorCountry.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorCountry.Pages.Countries
{
    public class EditModel : PageModel
    {
        private readonly CountryContext _context;

        public EditModel(CountryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Country? Country { get; set; }

        public SelectList? Continents { get; set; }

        public async Task<IActionResult> OnGetAsync(string? id)
        {
            Continents = new SelectList(_context.Continents, nameof(Continent.ID), nameof(Continent.Name));

            if (string.IsNullOrEmpty(id))
            {
                Country = new Country();
            }
            else
            {
                Country = await _context.Countries.FindAsync(id);

                if (Country is null)
                {
                    return NotFound();
                }
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (string.IsNullOrEmpty(id))
            {
                _context.Countries.Add(Country!);
            }
            else
            {
                _context.Attach(Country!).State = EntityState.Modified;
            }

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}