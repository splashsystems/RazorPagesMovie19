using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie19.Models;

namespace RazorPagesMovie19.Data
{
    public class RazorPagesMovie19Context : DbContext
    {
        public RazorPagesMovie19Context (DbContextOptions<RazorPagesMovie19Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie19.Models.Movie> Movie { get; set; }
    }
}
