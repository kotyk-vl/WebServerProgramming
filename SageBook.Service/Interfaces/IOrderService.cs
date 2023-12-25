using SageBook.Service.Models.Order;

namespace SageBook.Service.Interfaces
{
    public interface IOrderService
    {
        IQueryable<OrderModel> GetOrders();

        OrderModel? GetOrderById(int id);

        OrderModel? GetOrderByUserId(string userId);

        OrderModel AddNewOrder(OrderModel order);

        OrderModel EditOrder(OrderModel order);

        void DeleteOrder(int id);
    }
}