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
        }
    }
}