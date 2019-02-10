using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleListView.Data;
using SimpleListView.Models;
using Microsoft.EntityFrameworkCore;

namespace SimpleListView.Controllers
{
    public class HomeController : Controller
    {
        private readonly MovieDbContext _context;

        public HomeController(MovieDbContext context)
        {
            _context = context;
        }

        // GET: Movies        
        public async Task<IActionResult> Index([Bind("PageNo,PageSize")] Pagination pagination) // Bind PageNo and PageSize with pagination model.
        {
            var query = _context.Movies.AsNoTracking().OrderBy(m => m.Title);  // Prepare Query
            pagination.TotalCount = await query.CountAsync().ConfigureAwait(false); // Get the Record TotalCount.

            var result = await query.Skip((pagination.PageNo - 1) * pagination.PageSize).Take(pagination.PageSize).ToListAsync(); // Retrieve data based on Page No. and Page Size
            return View(new Tuple<IEnumerable<Movie>, Pagination>(result, pagination)); // Return 2 Models, Movie Model and Pagination Model
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
