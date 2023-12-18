namespace SageBook.Service.Models.Order
{
    public class OrderModel
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string UserId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}