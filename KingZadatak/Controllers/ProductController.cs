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

        /// <summary>
        /// Retrieves a list of all products.
        /// </summary>
        /// <returns>A view with the list of products.</returns>
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
        
        /// <summary>
        /// Retrieves the details of a specific product.
        /// </summary>
        /// <param name="id">The ID of the product.</param>
        /// <returns>A view with the product details.</returns>
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

        /// <summary>
        /// Filters products by category and price range.
        /// </summary>
        /// <param name="category">The product category.</param>
        /// <param name="minPrice">The minimum price.</param>
        /// <param name="maxPrice">The maximum price.</param>
        /// <returns>A view with the filtered list of products.</returns>
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

        /// <summary>
        /// Searches for products by title.
        /// </summary>
        /// <param name="searchString">The search string.</param>
        /// <returns>A view with the search results.</returns>
        public IActionResult Search(string? searchString)
        {
            List<ProductDetails> ProductDetailsList = _db.Products.
                 Where(p => p.Title.Contains(searchString) || string.IsNullOrEmpty(searchString)).ToList();
            List<Product> objProductList = ProductDetailsList.Select(pd => ConvertToProduct(pd)).ToList();
            return View(objProductList);
        }
    }
}
