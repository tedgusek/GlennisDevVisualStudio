using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecipeShare.Models;
using System;

namespace RecipeShare.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipes>(b =>
            {
                b.Property<int>("RecipeId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INT")
                    .IsRequired();

                b.Property<string>("Title")
                    .HasColumnType("NVARCHAR(MAX)")
                    .IsRequired();

                b.Property<string>("Instructions")
                    .HasColumnType("NVARCHAR(MAX)")
                    .IsRequired();

                b.Property<string>("Image")
                    .HasColumnType("NVARCHAR(MAX)");

                b.Property<double>("Ratings")
                    .HasColumnType("FLOAT");

                b.Property<string>("Comments")
                    .HasColumnType("NVARCHAR(MAX)");

                b.HasKey("RecipeId");

                b.ToTable("Recipes");
            });

            // Add configuration for other tables/entities if needed

            // Disable the following warning, if any
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            // Add configuration for other tables/entities if needed

            // Enable the following warning, if any
#pragma warning restore 612, 618
        }
    }
}
