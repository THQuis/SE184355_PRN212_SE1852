using System.Collections.Generic;
using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class OrderRepositories : IOrderRepositories
    {
        // Singleton pattern (giống các Repository khác)
        private static OrderRepositories? instance = null;
        private static readonly object instanceLock = new object();

        public static OrderRepositories Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderRepositories();
                    }
                    return instance;
                }
            }
        }

        // Constructor private
        private OrderRepositories() { }

        public List<Order> GetAllOrders()
        {
            return OrderDAO.GetAllOrders();
        }

        public Order? GetOrderById(int id)
        {
            return OrderDAO.GetOrderById(id);
        }

        public List<OrderDetail> GetOrderDetails(int orderId)
        {
            return OrderDAO.GetOrderDetails(orderId);
        }

        public void AddOrder(Order order, List<OrderDetail> details)
        {
            OrderDAO.AddOrder(order, details);
        }
    }
}