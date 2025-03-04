using Microsoft.AspNetCore.Mvc;
using MigrationWeb.Models;

namespace MigrationWeb.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var product = _context.Products.ToList();
            return View(product);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
