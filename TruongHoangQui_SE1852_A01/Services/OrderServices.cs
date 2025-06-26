using System.Collections.Generic;
using BusinessObjects;
using Repositories;

namespace Services
{
    public class OrderServices : IOrderServices
    {
        private readonly IOrderRepositories orderRepositories;

        public OrderServices()
        {
            orderRepositories = OrderRepositories.Instance;
        }

        public List<Order> GetAllOrders()
        {
            return orderRepositories.GetAllOrders();
        }

        public Order? GetOrderById(int id)
        {
            return orderRepositories.GetOrderById(id);
        }

        public List<OrderDetail> GetOrderDetails(int orderId)
        {
            return orderRepositories.GetOrderDetails(orderId);
        }

        public void AddOrder(Order order, List<OrderDetail> details)
        {
            orderRepositories.AddOrder(order, details);
        }
    }
}