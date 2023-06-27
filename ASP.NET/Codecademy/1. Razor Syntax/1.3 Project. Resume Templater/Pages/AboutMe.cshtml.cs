namespace ResumeTemplater.Pages

{
	using Microsoft.AspNetCore.Mvc.RazorPages;

	public class AboutMeModel : PageModel
	{
		public string Email { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public void OnGet()
		{
			Description = "Hello! I'm Alexey, a BSU FAMCS student born in Minsk, Belarus, who enjoys building things that live on the internet. I focus on developing web apps that provide intuitive user interfaces with efficient and modern backends.";
			Email = "kendyslesha@gmail.com";
		}
	}
}
