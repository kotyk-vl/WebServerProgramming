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

        public Order EditOrder(Order order)
        {
            var orderToUpdate = _context.Orders.FirstOrDefault(x => x.OrderId == order.OrderId);
            orderToUpdate.CanceledDate = DateTime.Now;
            _context.SaveChanges();

            return orderToUpdate;
        }

        public void DeleteOrder(int id)
        {
            var order = _context.Orders.First(x => x.OrderId == id);
            _context.Orders.Remove(order);
            _context.SaveChanges();
        }
    }
}