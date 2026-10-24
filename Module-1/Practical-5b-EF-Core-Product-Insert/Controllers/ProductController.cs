using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;
using WebApplication5.Models.Data;

namespace WebApplication5.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        // Display Form
        public IActionResult Index()
        {
            return View();
        }

        // Insert Product
        [HttpPost]
        public IActionResult Index(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();

                ViewBag.Message = "Product Inserted Successfully";
                ModelState.Clear();
            }

            return View();
        }
    }
}
