using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ActivityTracker.Pages
{
    public class ProgressCirclePartialModel : PageModel
    {
        public string BackgroundStroke { get; set; } = string.Empty;
        public string ForegroundStroke { get; set; } = string.Empty;
        public double PercentProgress { get; set; }
        public double DisplayNumber { get; set; }
        public string Unit { get; set; } = string.Empty;
        public string IconUrl { get; set; } = string.Empty;
    }
}