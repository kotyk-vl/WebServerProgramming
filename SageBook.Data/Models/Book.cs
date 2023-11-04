namespace SageBook.Data.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<SageBook> SageBooks { get; set; } = new List<SageBook>();
}