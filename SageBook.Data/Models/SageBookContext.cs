using Microsoft.EntityFrameworkCore;
using SageBook.Data.Configurations;
using System.Configuration;

namespace SageBook.Data.Models;

public partial class SageBookContext : DbContext
{
    public SageBookContext()
    {
    }

    public SageBookContext(DbContextOptions<SageBookContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }
    public virtual DbSet<Sage> Sages { get; set; }
    //public virtual DbSet<SageBook> SageBooks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["SageBookContext"].ConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BookConfiguration());
        modelBuilder.ApplyConfiguration(new SageConfiguration());
        //modelBuilder.ApplyConfiguration(new SageBookConfiguration());
    }
}