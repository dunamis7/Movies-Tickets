using etickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace etickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;

        public CinemasController(AppDbContext context)
        {
            _context = context;

        }

        public async Task<IActionResult> Index()
        {
            var allcinemas = await _context.Cinemas.ToListAsync();
            return View(allcinemas);
        }
    }
}
