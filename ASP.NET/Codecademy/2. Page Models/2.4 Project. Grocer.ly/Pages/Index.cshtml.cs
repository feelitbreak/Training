using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using GroceryStore.Models;
using System.Xml.Linq;

namespace GroceryStore.Pages
{
    public class IndexModel : PageModel
    {
        public List<GroceryItem> Foods { get; } = Inventory.ToList();

        [BindProperty]
        public int Rating { get; set; }

        [BindProperty]
        public string Feedback { get; set; } = string.Empty;

        public void OnGet()
        {

        }

        public async Task OnPostAsync()
        {
            using StreamWriter writer = new("feedback.txt", append: true);
            await writer.WriteLineAsync($"Rating: {Rating}. Feedback: {Feedback}");
        }
    }
}
