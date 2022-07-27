using EcommerceWeb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceWeb.Controllers
{
    public class CinemasController : Controller
    {

        private readonly AppDbcontext _context;
        public CinemasController(AppDbcontext context)
        {
            context = _context;
        }
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _context.Cinemas.ToListAsync();
            return View();
        }
    }
}
