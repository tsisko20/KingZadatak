using KingZadatak.Data;
using KingZadatak.Models;
using Microsoft.AspNetCore.Mvc;

namespace KingZadatak.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ProductController(ApplicationDbContext db) 
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Product> objProductList = _db.Products.ToList();
            return View(objProductList);
        }
    }
}
