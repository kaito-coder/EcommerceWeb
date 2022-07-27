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
            context = _context;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.Movies.ToListAsync();
            return View();
        }
    }
}
