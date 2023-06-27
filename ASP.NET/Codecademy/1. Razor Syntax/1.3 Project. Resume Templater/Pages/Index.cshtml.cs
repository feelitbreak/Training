using ResumeTemplater.Models;

namespace ResumeTemplater.Pages
{
	using Microsoft.AspNetCore.Mvc.RazorPages;

	public class IndexModel : PageModel
	{
		public string FullName { get; set; } = string.Empty;

		public string LinkedInUsername { get; set; } = string.Empty;

		public int YearsOfExperience { get; set; }

		public List<string> Languages { get; set; } = new();

		public void OnGet()
		{
			FullName = "Alexey Kendys";
			LinkedInUsername = "feelitbreak";
			YearsOfExperience = 3;
			Languages = new()
			{
				"English",
				"Russian",
				"Belarusian",
			};
		}
	}
}
