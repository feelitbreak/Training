﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blog.Pages
{
    public class IndexModel : PageModel
    {
        public string RequestMethod
        { get; set; } = string.Empty;

        public string RequestValues
        { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Body { get; set; } = string.Empty;

        public void OnGet()
        {
            // For debugging
            RequestMethod = "GET";
            RequestValues = "n/a";

            // Assign property values here
            Title = "Cuban Midnight Sandwich";
            Date = new DateTime(2000, 3, 24);
            Body = "This sandwich is called a ‘Media Noche’ which translates to ‘Midnight.’";
        }

        public void OnPost()
        {
            // For debugging
            RequestMethod = "POST";
            RequestValues = GetFormValues();

            // Assign property values here

        }

        // For debugging
        private string GetFormValues(bool ignoreRequestVerificationToken = true)
        {
            string formData = "";
            string separator = " | ";

            foreach (var pair in this.Request.Form)
            {
                if (ignoreRequestVerificationToken && pair.Key == "__RequestVerificationToken")
                {
                    continue;
                }
                else
                {
                    formData += pair.Key + ": " + Request.Form[pair.Key] + separator;
                }
            }

            if (formData.EndsWith(separator))
            {
                formData = formData.Substring(0, formData.Length - separator.Length);
            }

            return formData;
        }
    }
}