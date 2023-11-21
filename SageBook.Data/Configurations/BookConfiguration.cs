using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SageBook.Data.Models;

namespace SageBook.Data.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(e => e.BookId).HasName("PK_BookId");

            builder.ToTable("Book");

            builder.Property(e => e.Description).HasMaxLength(500);
            builder.Property(e => e.Name).HasMaxLength(50);

            builder.HasMany(s => s.Sages)
                .WithMany(b => b.Books)
                .UsingEntity<Dictionary<string, object>>("SageBook",
                    j => j.HasOne<Sage>().WithMany().HasForeignKey("SageId"),
                    j => j.HasOne<Book>().WithMany().HasForeignKey("BookId"),
                    j => j.ToTable("SageBook")
                );
        }
    }
}