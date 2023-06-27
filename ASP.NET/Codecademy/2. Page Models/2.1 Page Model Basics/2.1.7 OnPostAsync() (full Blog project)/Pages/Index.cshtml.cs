using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blog.Pages
{
    public class IndexModel : PageModel
    {
        public string RequestMethod
        { get; set; } = string.Empty;

        public string RequestValues
        { get; set; } = string.Empty;

        [BindProperty]
        public string Title { get; set; } = string.Empty;

        [BindProperty]
        public DateTime Date { get; set; }

        [BindProperty]
        public string Body { get; set; } = string.Empty;

        public async Task OnGetAsync()
        {
            // For debugging
            RequestMethod = "GET";
            RequestValues = "n/a";

            // Assign property values here
            Title = "Cuban Midnight Sandwich";
            Date = new DateTime(2000, 3, 24);
            Body = "This sandwich is called a 'Media Noche' which translates to 'Midnight.' It makes a wonderful dinner sandwich because it is served hot. A nice side dish is black bean soup or black beans and rice, and plaintain chips.";

            // Asynchronous task
            using StreamWriter writer = new("log.txt", append: true);
            await writer.WriteLineAsync($"OnGetAsync() called at {DateTime.Now}.");
        }

        public async Task OnPostAsync()
        {
            // For debugging
            RequestMethod = "POST";
            RequestValues = GetFormValues();

            using StreamWriter writer = new("log.txt", append: true);
            await writer.WriteLineAsync($"OnPostAsync() called at {DateTime.Now}.");
        }

        // For debugging
        private string GetFormValues(bool ignoreRequestVerificationToken = true)
        {
            string separator = " | ";
            StringBuilder formDataSB = new ();

            foreach (var key in this.Request.Form.Select(pair => pair.Key))
            {
                if (ignoreRequestVerificationToken && key == "__RequestVerificationToken")
                {
                    continue;
                }
                else
                {
                    formDataSB.Append(key);
                    formDataSB.Append(": ");
                    formDataSB.Append(Request.Form[key]);
                    formDataSB.Append(separator);
                }
            }

            string formData = formDataSB.ToString();
            if (formData.EndsWith(separator))
            {
                formData = formData[..^separator.Length];
            }

            return formData;
        }
    }
}