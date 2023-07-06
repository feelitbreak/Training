using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using DependencyInjection.Services;

namespace DependencyInjection.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IDataStore _dataStore;
        private readonly IStringGenerator _stringGenerator;

        public List<string>? Items { get; set; }

        public string? Superpower { get; set; }

        public IndexModel(IDataStore dataStore, IStringGenerator stringGenerator)
        {
            _dataStore = dataStore;
            _stringGenerator = stringGenerator;
        }

        // Set Superpower here
        public void OnGet()
        {
            Items = _dataStore.GetAll();
            Superpower = _stringGenerator.Generate();
        }
    }
}
