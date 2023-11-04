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

            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        }
    }
}