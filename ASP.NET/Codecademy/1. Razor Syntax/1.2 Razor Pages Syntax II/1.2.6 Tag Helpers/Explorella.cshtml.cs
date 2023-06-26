namespace RazorSyntaxSecondTry.Namespace
{
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class ExplorellaModel : PageModel
    {
        public string Country { get; set; }

        public List<SelectListItem> Countries { get; set; }

        public void OnGet()
        {
            Countries = new ()
            {
                new SelectListItem("Argentina", "AR"),
                new SelectListItem("France", "FR"),
                new SelectListItem("Brazil", "BR"),
                new SelectListItem("Germany", "GER"),
                new SelectListItem("China", "CHI"),
            };
        }
    }
}
