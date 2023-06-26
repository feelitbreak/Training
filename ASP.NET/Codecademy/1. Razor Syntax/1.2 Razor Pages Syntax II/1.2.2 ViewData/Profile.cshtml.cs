namespace RazorSyntaxSecondTry.Namespace
{
    using Microsoft.AspNetCore.Mvc.RazorPages;

    public class ProfileModel : PageModel
    {
        public void OnGet()
        {
            ViewData["myName"] = "Alexey Kendys";
            ViewData["username"] = "feelitbreak";
            ViewData["myOccupation"] = "BSU FAMCS Student";
            ViewData["myAge"] = 20;
            ViewData["currentDate"] = "06/26/23";
        }
    }
}
