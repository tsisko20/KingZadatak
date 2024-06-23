using KingZadatak.Data;
using KingZadatak.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;

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
            List < Product > objProductList = _db.Products.ToList();
            return View(objProductList);
        }

        public IActionResult Details(int? id) {
            
            var product = _db.Products
                .FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
                          
        }
        
    }
}
