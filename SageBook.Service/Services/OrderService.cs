using SageBook.Data.Models;
using SageBook.Repository.Interfaces;
using SageBook.Service.Interfaces;
using SageBook.Service.Models.Order;

namespace SageBook.Service.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IQueryable<OrderModel> GetOrders()
        {
            return _orderRepository.GetOrders()
                .Select(OrderToModel)
                .AsQueryable();
        }

        public OrderModel? GetOrderById(int id)
        {
            return GetOrders().FirstOrDefault(o => o.Id == id);
        }

        public OrderModel? GetOrderByUserId(string userId)
        {
            return GetOrders().FirstOrDefault(o => o.UserId == userId);
        }

        public OrderModel AddNewOrder(OrderModel order)
        {
            var newOrder = _orderRepository.AddNewOrder(OrderFromModel(order));
            return OrderToModel(newOrder);
        }

        public OrderModel EditOrder(OrderModel order)
        {
            var updatedOrder = _orderRepository.EditOrder(OrderFromModel(order));
            return OrderToModel(updatedOrder);
        }

        public void DeleteOrder(int orderId)
        {
            _orderRepository.DeleteOrder(orderId);
        }

        private readonly Func<Order, OrderModel> OrderToModel = (order) => new OrderModel
        {
            Id = order.OrderId,
            UserId = order.UserId,
            BookId = order.BookId,
            CreatedDate = order.CreatedDate,
            CanceledDate = order.CanceledDate,
        };

        private readonly Func<OrderModel, Order> OrderFromModel = (order) => new Order
        {
            OrderId = order.Id,
            UserId = order.UserId,
            BookId = order.BookId,
            CreatedDate = order.CreatedDate,
            CanceledDate = order.CanceledDate,
        };
    }
}