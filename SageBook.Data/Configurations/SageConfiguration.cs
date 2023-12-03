using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SageBook.Data.Models;

namespace SageBook.Data.Configurations
{
    public class SageConfiguration : IEntityTypeConfiguration<Sage>
    {
        public void Configure(EntityTypeBuilder<Sage> entity)
        {
            entity.HasKey(e => e.SageId).HasName("PK_SageId");

            entity.ToTable("Sage");

            entity.Property(e => e.Name).HasMaxLength(50).IsRequired();
            entity.Property(e => e.Age).IsRequired();
            entity.Property(e => e.Photo);
            entity.Property(e => e.City).HasMaxLength(50);
        }
    }
}