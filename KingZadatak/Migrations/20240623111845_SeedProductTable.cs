using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KingZadatak.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Price", "Thumbnail", "Title" },
                values: new object[,]
                {
                    { 1, "Product1 Description", 5.9900000000000002, "https://i5.walmartimages.com/seo/CifToys-Trex-Dinosaur-Toys-for-Kids-3-5-T-Rex-Toy-Realistic-Tyrannosaurus-Rex_847a91dd-8df3-4fae-a2a5-1b266bdfd870.c0bc20b87ca2e6ad8246979ab17342dd.jpeg", "Product1" },
                    { 2, "Product3 Description", 19.989999999999998, "https://m.media-amazon.com/images/I/51C5TrSt-GL.jpg", "Product3" },
                    { 3, "Product3 Description", 99.989999999999995, "https://toyzone.in/cdn/shop/products/723934.jpg?v=1668491719", "Product3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
