using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using DependencyInjection.Services;
using DependencyInjection.Models;
using DependencyInjection.Data;
using Microsoft.EntityFrameworkCore;

namespace DependencyInjection.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IDataStore _dataStore;
        private readonly TowerContext _context;
        private readonly ILogger<IndexModel> _logger;

        public List<string>? Items { get; set; }

        public List<Tower>? Towers { get; set; }

        public IndexModel(IDataStore dataStore, TowerContext context, ILogger<IndexModel> logger)
        {
            _dataStore = dataStore;
            _context = context;
            _logger = logger;
        }

        // Set Superpower here
        public async Task OnGetAsync()
        {
            Items = _dataStore.GetAll();
            Towers = await _context.Towers.ToListAsync();
        }
    }
}
