namespace SageBook.Service.Models.Sage
{
    public class SageModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public byte[]? Photo { get; set; }
        public string? City { get; set; }
        public List<int> BookIds { get; set; }

        public SageModel()
        {
            Name = string.Empty;
            BookIds = new List<int>();
        }
    }
}