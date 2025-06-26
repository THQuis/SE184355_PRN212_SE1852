using System;
using System.Collections.Generic;
using System.Linq;
using BusinessObjects;

namespace DataAccessLayer
{
    public static class OrderDAO
    {
        private static readonly List<Order> Orders = new();
        private static readonly List<OrderDetail> OrderDetails = new();

        static OrderDAO()
        {
            InitializeDataset();
        }

        private static void InitializeDataset()
        {
            if (!Orders.Any())
            {
                Orders.Add(new Order { OrderID = 1, CustomerID = 1, EmployeeID = 1, OrderDate = new DateTime(2025, 6, 1) });
                Orders.Add(new Order { OrderID = 2, CustomerID = 2, EmployeeID = 2, OrderDate = new DateTime(2025, 6, 15) });

                OrderDetails.Add(new OrderDetail { OrderID = 1, ProductID = 1, UnitPrice = 15000, Quantity = 2, Discount = 0f });
                OrderDetails.Add(new OrderDetail { OrderID = 1, ProductID = 2, UnitPrice = 55000, Quantity = 1, Discount = 0.1f });
                OrderDetails.Add(new OrderDetail { OrderID = 2, ProductID = 3, UnitPrice = 25000, Quantity = 4, Discount = 0.05f });
            }
        }

        public static List<Order> GetAllOrders() => Orders;

        public static List<OrderDetail> GetOrderDetails(int orderId)
        {
            return OrderDetails.Where(od => od.OrderID == orderId).ToList();
        }

        public static void AddOrder(Order order, List<OrderDetail> details)
        {
            order.OrderID = Orders.Any() ? Orders.Max(o => o.OrderID) + 1 : 1;
            Orders.Add(order);

            foreach (var detail in details)
            {
                detail.OrderID = order.OrderID;
                OrderDetails.Add(detail);
            }
        }

        public static Order? GetOrderById(int id) => Orders.FirstOrDefault(o => o.OrderID == id);
    }
}