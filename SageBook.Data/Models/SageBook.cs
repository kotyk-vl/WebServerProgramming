namespace SageBook.Data.Models;

public partial class SageBook
{
    public int SageBookId { get; set; }

    public int SageId { get; set; }

    public int BookId { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual Sage Sage { get; set; } = null!;
}