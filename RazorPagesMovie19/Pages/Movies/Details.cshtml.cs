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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovie19.Data.RazorPagesMovie19Context _context;

        public DetailsModel(RazorPagesMovie19.Data.RazorPagesMovie19Context context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
