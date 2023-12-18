using SageBook.Data.Models;

namespace SageBook.Repository.Interfaces
{
    public interface IOrderRepository
    {
        IQueryable<Order> GetOrders();

        Order AddNewOrder(Order order);
    }
}