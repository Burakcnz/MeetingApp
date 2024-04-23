using Microsoft.EntityFrameworkCore;

namespace ToplantıKatılımUygulaması.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ApplyModel> ApplyModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplyModel>()
                .Property(m => m.FullName)
                .HasMaxLength(100);

            modelBuilder.Entity<ApplyModel>()
                .Property(m => m.Email)
                .HasMaxLength(100);

            modelBuilder.Entity<ApplyModel>()
                .Property(m => m.Phone)
                .HasMaxLength(15);

        }
    }
}
