using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using products_crud.Context;

namespace products_crud.Migrations
{
    [DbContext(typeof(ProductsContext))]
    [Migration("20170618214626_efmigration")]
    partial class efmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("products_crud.Models.Category", b =>
                {
                    b.Property<int>("categoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("categoryName");

                    b.Property<int?>("productId");

                    b.HasKey("categoryId");

                    b.HasIndex("productId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("products_crud.Models.Product", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("categoryId");

                    b.Property<string>("productDescription");

                    b.Property<string>("productImagePath");

                    b.Property<string>("productName");

                    b.Property<float>("productPrice");

                    b.Property<float>("productRating");

                    b.HasKey("productId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("products_crud.Models.Category", b =>
                {
                    b.HasOne("products_crud.Models.Product")
                        .WithMany("Categories")
                        .HasForeignKey("productId");
                });
        }
    }
}
