using KingZadatak.Models;
using Microsoft.EntityFrameworkCore;

namespace KingZadatak.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product 
                { 
                    Id=1, 
                    Title="Product1", 
                    Description="Product1 Description", 
                    Price=5.99, 
                    Thumbnail= "https://i5.walmartimages.com/seo/CifToys-Trex-Dinosaur-Toys-for-Kids-3-5-T-Rex-Toy-Realistic-Tyrannosaurus-Rex_847a91dd-8df3-4fae-a2a5-1b266bdfd870.c0bc20b87ca2e6ad8246979ab17342dd.jpeg" },
                new Product
                {
                    Id = 2,
                    Title = "Product3",
                    Description = "Product3 Description",
                    Price = 19.99,
                    Thumbnail = "https://m.media-amazon.com/images/I/51C5TrSt-GL.jpg"
                },
                new Product
                {
                    Id = 3,
                    Title = "Product3",
                    Description = "Product3 Description",
                    Price = 99.99,
                    Thumbnail = "https://toyzone.in/cdn/shop/products/723934.jpg?v=1668491719"
                }
                );
        }
    }
}
