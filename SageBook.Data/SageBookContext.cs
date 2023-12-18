using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SageBook.Data.Configurations;
using System.Configuration;

namespace SageBook.Data.Models;

public partial class SageBookContext : IdentityDbContext
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

    public virtual DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        #region WinForm Connection

        var context = ConfigurationManager.ConnectionStrings["SageBookContext"];

        if (context != null)
        {
            optionsBuilder.UseSqlServer(context.ConnectionString);
        }

        #endregion WinForm Connection
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new BookConfiguration());
        modelBuilder.ApplyConfiguration(new SageConfiguration());
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
    }
}