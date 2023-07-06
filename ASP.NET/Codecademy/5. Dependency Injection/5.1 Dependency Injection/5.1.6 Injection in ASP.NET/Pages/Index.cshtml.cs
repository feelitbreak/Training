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

        public List<string>? Items { get; set; }

        public IndexModel(IDataStore dataStore)
        {
            _dataStore = dataStore;
        }

        // Set Items in here
        public void OnGet()
        {
            Items = _dataStore.GetAll();
        }
    }
}
