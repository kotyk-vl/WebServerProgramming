namespace SageBook.Service.Models.Book
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public List<int> SageIds;

        public BookModel()
        {
            Name = string.Empty;
            SageIds = new List<int>();
        }
    }
}