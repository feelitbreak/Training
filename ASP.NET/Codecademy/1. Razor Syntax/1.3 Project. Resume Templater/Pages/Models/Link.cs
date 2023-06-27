namespace ResumeTemplater.Models
{
	public class Link
	{
        public enum LinkType
        {
            GitHub,
            LinkedIn,
        }

        public LinkType Type { get; set; }

		public string URLPath { get; set; }

		public Link(LinkType linkType, string urlPath)
		{
			Type = linkType;

			if (LinkType.GitHub == linkType)
			{
                URLPath = "http://www.github.com/" + urlPath;
            }
            else
            {
                URLPath = "http://www.linkedin.com/" + urlPath;
            }
		}
	}
}
