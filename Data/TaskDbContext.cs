using Microsoft.EntityFrameworkCore;
using WebApplication1.NewFolder;

namespace WebApplication1.Data
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<State>()
                .HasOne(s => s.Country)
                .WithMany(c => c.States)
                .HasForeignKey(s => s.Cid);
        }
    }
}
