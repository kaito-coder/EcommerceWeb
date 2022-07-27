using EcommerceWeb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceWeb.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbcontext _context;
        public ProducersController(AppDbcontext context)
        {
            context = _context;
        }
        public async  Task<IActionResult> Index()
        {
            var allProducers = await _context.Producers.ToListAsync();
            return View();
        }
    }
}
