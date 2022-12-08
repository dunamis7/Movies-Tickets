using etickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace etickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;

        public ProducersController(AppDbContext context)
        {
            _context = context;
        }

        //Asynchonous way of fetching data from the database
        public async Task <IActionResult> Index()
        {
            var data = await _context.Producers.ToListAsync();
            return View(data);
        }
    }
}
