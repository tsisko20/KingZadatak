using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KingZadatak.Migrations
{
    /// <inheritdoc />
    public partial class AddProductDetailsTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Category", "Description", "Price", "Thumbnail", "Title" },
                values: new object[,]
                {
                    { 1, "ToyCreator", "Toy", "Product1 Description", 5.9900000000000002, "https://i5.walmartimages.com/seo/CifToys-Trex-Dinosaur-Toys-for-Kids-3-5-T-Rex-Toy-Realistic-Tyrannosaurus-Rex_847a91dd-8df3-4fae-a2a5-1b266bdfd870.c0bc20b87ca2e6ad8246979ab17342dd.jpeg", "Product1" },
                    { 2, "ToyCreator", "Toy", "Product3 Description", 19.989999999999998, "https://m.media-amazon.com/images/I/51C5TrSt-GL.jpg", "Product3" },
                    { 3, "ToyCreator", "War", "Product3 Description", 99.989999999999995, "https://toyzone.in/cdn/shop/products/723934.jpg?v=1668491719", "Product3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
