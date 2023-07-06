using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DependencyInjection.Models;

namespace DependencyInjection.Data
{
    public class TowerContext : DbContext
    {
        public TowerContext (DbContextOptions<TowerContext> options)
            : base(options)
        {
        }

        public DbSet<DependencyInjection.Models.Tower> Towers { get; set; } = default!;
    }
}
