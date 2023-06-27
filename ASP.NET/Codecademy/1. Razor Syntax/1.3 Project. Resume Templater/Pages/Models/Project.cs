namespace ResumeTemplater.Models
{
	public class Project
	{
		public string Title { get; set; } = string.Empty;

		public string Description { get; set; } = string.Empty;

		public int Year { get; set; }

		public List<string> Technologies { get; set; } = new();
	}
}