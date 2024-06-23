﻿// <auto-generated />
using KingZadatak.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KingZadatak.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240623151442_AddDescriptionLengthConstraint")]
    partial class AddDescriptionLengthConstraint
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KingZadatak.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Product1 Description",
                            Price = 5.9900000000000002,
                            Thumbnail = "https://i5.walmartimages.com/seo/CifToys-Trex-Dinosaur-Toys-for-Kids-3-5-T-Rex-Toy-Realistic-Tyrannosaurus-Rex_847a91dd-8df3-4fae-a2a5-1b266bdfd870.c0bc20b87ca2e6ad8246979ab17342dd.jpeg",
                            Title = "Product1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Product3 Description",
                            Price = 19.989999999999998,
                            Thumbnail = "https://m.media-amazon.com/images/I/51C5TrSt-GL.jpg",
                            Title = "Product3"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Product3 Description",
                            Price = 99.989999999999995,
                            Thumbnail = "https://toyzone.in/cdn/shop/products/723934.jpg?v=1668491719",
                            Title = "Product3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
