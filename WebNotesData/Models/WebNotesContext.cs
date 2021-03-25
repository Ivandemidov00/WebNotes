using Microsoft.EntityFrameworkCore;

namespace WebNotesData.Models
{
    public class WebNotesContext : DbContext
    {
        public DbSet<categories> categories { get; set; }
        public DbSet<user> user { get; set; }
        public DbSet<posts> posts { get; set; }
        public WebNotesContext(DbContextOptions<WebNotesContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<categories>().HasMany(c => c.posts).WithOne(e => e.categories);
            modelBuilder.Entity<user>().HasMany(r => r.posts).WithOne(y => y.user);
            modelBuilder.Entity<posts>().HasOne(e => e.categories).WithMany(c => c.posts);
            modelBuilder.Entity<posts>().HasOne(y => y.user).WithMany(r => r.posts);
        }
    }
}
