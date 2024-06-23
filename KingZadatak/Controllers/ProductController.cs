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
            List<ProductDetails> ProductDetailsList = _db.Products.ToList();
            List<Product> objProductList = ProductDetailsList.Select(pd => ConvertToProduct(pd)).ToList();

            return View(objProductList);

        }

        public Product ConvertToProduct(ProductDetails productDetails)
        {
            return new Product
            {
                Id = productDetails.Id,
                Title = productDetails.Title,
                Price = productDetails.Price,
                Description = productDetails.Description,
                Thumbnail = productDetails.Thumbnail
            };
        }

        public IActionResult Details(int? id)
        {

            var productDetails = _db.Products
                .FirstOrDefault(x => x.Id == id);
            if (productDetails == null)
            {
                return NotFound();
            }
            return View(productDetails);

        }

        public IActionResult Filter(string? category, double? minPrice, double? maxPrice)
        {
            List<ProductDetails> ProductDetailsList = _db.Products.
                Where( p => 
                (string.IsNullOrEmpty(category) || p.Category==category) &&
                (minPrice == null || p.Price >= minPrice) && 
                (maxPrice == null || p.Price <= maxPrice)).ToList();
            List<Product> objProductList = ProductDetailsList.Select(pd => ConvertToProduct(pd)).ToList();
            return View(objProductList);
        }

        public IActionResult Search(string? searchString)
        {
            List<ProductDetails> ProductDetailsList = _db.Products.
                 Where(p => p.Title.Contains(searchString) || string.IsNullOrEmpty(searchString)).ToList();
            List<Product> objProductList = ProductDetailsList.Select(pd => ConvertToProduct(pd)).ToList();
            return View(objProductList);
        }
    }
}
