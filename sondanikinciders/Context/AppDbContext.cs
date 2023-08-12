using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using sondanikinciders.Models;

namespace sondanikinciders.Context
{
    //public class AppDbContext : DbContext
    //{
    //    public DbSet<Book>  Books { get; set; }
    //    public DbSet<Author> Authors { get; set; }
    //    public DbSet<Contact> Contacts { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        optionsBuilder.UseSqlServer(@"Server=DESKTOP-Q3NBEGU;Database=DataAnnations;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    //        base.OnConfiguring(optionsBuilder);
    //    }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<Book>()
    //            .Property(t => t.Title)
    //            .HasColumnName("Description")
    //            .HasColumnType("nvarchar(50)")
    //            .HasColumnOrder(2)
    //            .IsRequired();


    //        modelBuilder.Entity<Author>()
    //            .Property(x => x.FirstName)
    //            .IsConcurrencyToken(true);

    //        modelBuilder.Entity<Contact>()
    //            .Property(x => x.LastAccessed)
    //            .ValueGeneratedOnAddOrUpdate().Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Save); 

    //        //modelBuilder.Entity<Contact>().Property(x => x.LastAccessed)
    //        //.HasValueGenerator<UtcDateTimeGenerator>()
    //        //.ValueGeneratedOnAddOrUpdate();

    //        modelBuilder.Entity<Contact>()
    //            .Property(y => y.CreateDate)
    //            .ValueGeneratedOnAdd();

    //        modelBuilder.Entity<Contact>()
    //            .Property(y => y.ModifiedDate)
    //            .ValueGeneratedOnUpdate();

    //        modelBuilder.Entity<Order>()
    //            .HasKey(o => o.OrderNumber);

    //        //modelBuilder.Entity<Order>()
    //        //    .Property(o => o.OrderCount)
    //        //    .UseIdentityColumn(1,1);

    //        modelBuilder.Entity<Contact>()
    //            .HasIndex(c => c.FirstName)
    //            .HasFilter("[LastName] IS NOT NULL");

    //        modelBuilder.Entity<Contact>()
    //            .Ignore(c => c.FullName);

    //        modelBuilder.Ignore<AuditLog>();

    //        modelBuilder.Entity<Book>()
    //            .Property(t => t.Title)
    //            .IsRequired();

    //        modelBuilder.Entity<Book>()
    //            .ToTable("tbl_book");

    //        base.OnModelCreating(modelBuilder);
    //    }
    //}
}
