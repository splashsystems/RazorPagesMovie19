using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie19.Data;
using RazorPagesMovie19.Models;

namespace RazorPagesMovie19.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie19.Data.RazorPagesMovie19Context _context;

        public IndexModel(RazorPagesMovie19.Data.RazorPagesMovie19Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
