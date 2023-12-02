using Microsoft.EntityFrameworkCore;
using minozas_catering_api_dotnet.Context.Seeders;
using minozas_catering_api_dotnet.Entities;

namespace minozas_catering_api_dotnet.Context
{
    public partial class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        { }
        public DbSet<Category> Category { get; set; } = default!;
        public DbSet<Food> Food { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Timestamps
            modelBuilder.Entity<Category>()
                .Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()").ValueGeneratedOnAdd();

            modelBuilder.Entity<Category>()
                .Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()").ValueGeneratedOnUpdate();

            modelBuilder.Entity<Food>()
                .Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()").ValueGeneratedOnAdd();

            modelBuilder.Entity<Food>()
                .Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()").ValueGeneratedOnUpdate();

            // Seeders
            modelBuilder.Entity<Category>().HasData(
                DatabaseSeeder.categories
            );

            modelBuilder.Entity<Food>().HasData(
                DatabaseSeeder.foods
            );
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
