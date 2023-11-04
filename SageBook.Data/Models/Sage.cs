namespace SageBook.Data.Models;

public partial class Sage
{
    public int SageId { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public byte[]? Photo { get; set; }

    public string? City { get; set; }

    public virtual ICollection<SageBook> SageBooks { get; set; } = new List<SageBook>();
}