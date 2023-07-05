using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CCsBakery.Pages
{
    [Authorize]
    public class MyOrdersModel : PageModel
    {
        private readonly ILogger<MyOrdersModel> _logger;

        public MyOrdersModel(ILogger<MyOrdersModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
