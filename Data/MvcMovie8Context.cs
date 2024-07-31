using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie8.Models;

namespace MvcMovie8.Data
{
    public class MvcMovie8Context : DbContext
    {
        public MvcMovie8Context (DbContextOptions<MvcMovie8Context> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie8.Models.Movie> Movie { get; set; } = default!;
        public DbSet<MvcMovie8.Models.Genre> Genre { get; set; } = default!;
    }
}
