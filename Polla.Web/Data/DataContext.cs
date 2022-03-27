using Microsoft.EntityFrameworkCore;
using Polla.Web.Data.Entities;

namespace Polla.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<TeamEntity> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TeamEntity>()
                .HasIndex(t => t.Name)
                .IsUnique();
        }
    }
}
