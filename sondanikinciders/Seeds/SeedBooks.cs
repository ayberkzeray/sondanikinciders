using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sondanikinciders.Models;

namespace sondanikinciders.Seeds
{
    public class SeedBooks : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                  new Book { BookId= 1, Title = "Suç ve Ceza", AuthorID = 2},
                  new Book { BookId= 2, Title = "Kalem ve Kağıt", AuthorID = 2},
                  new Book { BookId= 3, Title = "Lezzetin Tarihi", AuthorID = 2},
                  new Book { BookId= 4, Title = "Nitelikli Kahve", AuthorID = 2},
                  new Book { BookId= 5, Title = "Böyle Buyurdu Zerdüşt", AuthorID = 2}
                );
        }
    }
}
