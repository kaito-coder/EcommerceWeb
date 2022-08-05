using EcommerceWeb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceWeb.Controllers
{
    public class MoviesController : Controller
    {

        private readonly AppDbcontext _context;
        public MoviesController(AppDbcontext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.Movies.Include(n=> n.Cinema).ToListAsync();
            return View(allMovies);
        }
    }
}
