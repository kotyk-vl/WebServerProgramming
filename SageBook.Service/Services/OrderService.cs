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

        public OrderModel? GetOrderByUserId(string userId)
        {
            return GetOrders().FirstOrDefault(o => o.UserId == userId);
        }

        public void AddNewOrder(OrderModel order)
        {
            _orderRepository.AddNewOrder(OrderFromModel(order));
        }

        private readonly Func<Order, OrderModel> OrderToModel = (order) => new OrderModel
        {
            Id = order.OrderId,
            UserId = order.UserId,
            BookId = order.BookId,
            CreatedDate= order.CreatedDate,
        };

        private readonly Func<OrderModel, Order> OrderFromModel = (order) => new Order
        {
            OrderId = order.Id,
            UserId = order.UserId,
            BookId = order.BookId,
            CreatedDate = order.CreatedDate,
        };
    }
}