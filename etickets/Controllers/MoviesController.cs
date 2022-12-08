using etickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace etickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
    
        public async Task <IActionResult> Index()
        {
            var allmovies = await _context.Movies.Include(q => q.Cinema).OrderBy(n => n.Name).ToListAsync();
            return View(allmovies);
        }
    }
}
