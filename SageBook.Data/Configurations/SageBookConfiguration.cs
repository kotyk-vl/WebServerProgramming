using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SageBook.Data.Configurations
{
    public class SageBookConfiguration : IEntityTypeConfiguration<Models.SageBook>
    {
        public void Configure(EntityTypeBuilder<Models.SageBook> entity)
        {
            entity.HasKey(e => e.SageBookId).HasName("PK_SageBookId");

            entity.ToTable("SageBook");

            entity.HasOne(d => d.Book).WithMany(p => p.SageBooks)
                .HasForeignKey(d => d.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Sage).WithMany(p => p.SageBooks)
                .HasForeignKey(d => d.SageId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}