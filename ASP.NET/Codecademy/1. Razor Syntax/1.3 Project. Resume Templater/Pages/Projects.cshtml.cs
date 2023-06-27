using ResumeTemplater.Models;

namespace ResumeTemplater.Pages
{
	using Microsoft.AspNetCore.Mvc.RazorPages;
	using ResumeTemplater.Models;

	public class ProjectsModel : PageModel
	{
		public string GitHubUsername { get; set; } = string.Empty;

		public List<Project> Projects { get; set; } = new();

		public void OnGet()
		{
			GitHubUsername = "feelitbreak";

			Projects = new()
	  {
				new Project()
				{
					Title = "Explorella",
					Description = "A large scale travelling application built to help plan your destination and itinerary on your next trip! Built on React, Node, Express, and MongoDB.",
					Year = 2019,
		  Technologies = new ()
		  {
			"React",
			"Node",
			"Express",
			"MongoDB",
		  },
				},
				new Project()
				{
					Title = "Cypher Clothing",
					Description = "A large scale e-commerce clothing store application. Built with Razor Pages and SQLite.",
					Year = 2019,
		  Technologies = new ()
		  {
			"Razor Pages",
			"SQLite",
		  },
				},
				new Project()
				{
					Title = "Password Box",
					Description = "A password manager Chrome plugin used to create and safely store all your passwords! Built with Javascript and HTML.",
					Year = 2020,
		  Technologies = new ()
		  {
			"Javascript",
			"HTML",
		  },
				},
		new Project()
		{
		  Title = "Spotivize",
		  Description = "Spotivize is a music platform that uses geolocation to track when your favorite artists are playing in your local city! Built with Node, Express, React and MongoDB.",
		  Year = 2016,
		  Technologies = new ()
		  {
			"Node",
			"Express",
			"React",
			"MongoDB",
		  },
		}
			};
		}
	}
}
