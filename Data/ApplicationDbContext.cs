using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RecipeShare.Models;

namespace RecipeShare.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Recipes> Recipes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Recipes>(b =>
            {
                b.Property(r => r.RecipeId)
                    .ValueGeneratedOnAdd();

                b.Property(r => r.Title)
                    .IsRequired();

                b.Property(r => r.Instructions)
                    .IsRequired();

                b.Property(r => r.Image);

                b.Property(r => r.RatingsAverage);

                //b.Property(r => r.Comments);

                b.HasKey(r => r.RecipeId);

                b.ToTable("Recipes");
            });
        }
    }
}
