using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SageBook.Data.Models;

namespace SageBook.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(e => e.OrderId).HasName("PK_OrderId");

            builder.ToTable("Orders");

            builder.Property(e => e.BookId).IsRequired();
            builder.Property(e => e.UserId).HasMaxLength(450).IsRequired();
            builder.Property(e => e.CreatedDate).HasMaxLength(50);

            builder.HasOne(s => s.Book);
            builder.HasOne(s => s.User);
        }
    }
}