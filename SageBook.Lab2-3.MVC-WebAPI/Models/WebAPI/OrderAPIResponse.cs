namespace SageBook.Lab2_3.MVC_WebAPI.Models.WebAPI
{
    public class OrderAPIResponse
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string? BookName { get; set; }
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? CanceledDate { get; set; }
    }
}