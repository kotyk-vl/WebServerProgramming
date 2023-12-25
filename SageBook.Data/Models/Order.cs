using Microsoft.AspNetCore.Identity;

namespace SageBook.Data.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public string UserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? CanceledDate { get; set; }

        public virtual Book Book { get; set; }
        public virtual IdentityUser User { get; set; }
    }
}