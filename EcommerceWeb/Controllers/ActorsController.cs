using EcommerceWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWeb.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbcontext _context;
        public ActorsController(AppDbcontext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allActors = _context.Actors.ToList();

            return View(allActors);
        }
    }
}
