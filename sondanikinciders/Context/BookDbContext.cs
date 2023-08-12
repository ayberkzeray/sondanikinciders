using Microsoft.EntityFrameworkCore;
using sondanikinciders.Models;
using sondanikinciders.Seeds;

namespace sondanikinciders.Context
{
    public class BookDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-Q3NBEGU;Database=SeedData;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author { AuthorId = 1, FirstName = "Ayberk", LastName = "Zeray" },
                new Author { AuthorId = 2, FirstName = "Can", LastName = "Zeray" }
                );
            modelBuilder.ApplyConfiguration(new SeedBooks());
            base.OnModelCreating(modelBuilder);
        }
    }
}
