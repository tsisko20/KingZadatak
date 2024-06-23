using KingZadatak.Models;
using Microsoft.EntityFrameworkCore;

namespace KingZadatak.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<ProductDetails> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductDetails>().HasData(
                new ProductDetails
                { 
                    Id=1, 
                    Title="Product1", 
                    Description="Product1 Description", 
                    Price=5.99,
                    Category="Toy",
                    Brand="ToyCreator",
                    Thumbnail= "https://i5.walmartimages.com/seo/CifToys-Trex-Dinosaur-Toys-for-Kids-3-5-T-Rex-Toy-Realistic-Tyrannosaurus-Rex_847a91dd-8df3-4fae-a2a5-1b266bdfd870.c0bc20b87ca2e6ad8246979ab17342dd.jpeg" },
                new ProductDetails
                {
                    Id = 2,
                    Title = "Product2",
                    Description = "Product2 Description",
                    Price = 19.99,
                    Category = "Toy",
                    Brand = "ToyCreator",
                    Thumbnail = "https://m.media-amazon.com/images/I/51C5TrSt-GL.jpg"
                },
                new ProductDetails
                {
                    Id = 3,
                    Title = "Product3",
                    Description = "Product3 Description",
                    Price = 99.99,
                    Category = "War",
                    Brand = "ToyCreator",
                    Thumbnail = "https://toyzone.in/cdn/shop/products/723934.jpg?v=1668491719"
                }
                );
        }
    }
}
