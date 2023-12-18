using Microsoft.EntityFrameworkCore;
using SageBook.Data.Models;
using SageBook.Repository.Interfaces;

namespace SageBook.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly SageBookContext _context;

        public OrderRepository()
        {
            _context = new SageBookContext();
        }

        public OrderRepository(SageBookContext context)
        {
            _context = context;
        }

        public IQueryable<Order> GetOrders()
        {
            return _context.Orders
                .Include(u => u.User)
                .Include(b => b.Book)
                .AsNoTracking();
        }

        public Order AddNewOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
            return order;
        }
    }
}