using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearnRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        public string? Greet { get; set; }

        public void OnGet()
        {
            Greet = "Hey there!";
        }
    }
}