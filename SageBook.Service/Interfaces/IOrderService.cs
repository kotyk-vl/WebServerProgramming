using SageBook.Service.Models.Order;

namespace SageBook.Service.Interfaces
{
    public interface IOrderService
    {
        IQueryable<OrderModel> GetOrders();

        OrderModel? GetOrderByUserId(string userId);

        void AddNewOrder(OrderModel order);
    }
}