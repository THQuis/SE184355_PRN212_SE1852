using System.Collections.Generic;
using BusinessObjects;

namespace Services
{
    public interface IOrderServices
    {
        // Lấy tất cả đơn hàng
        List<Order> GetAllOrders();

        // Lấy đơn hàng theo ID
        Order? GetOrderById(int id);

        // Lấy danh sách chi tiết sản phẩm trong đơn hàng
        List<OrderDetail> GetOrderDetails(int orderId);

        // Thêm mới đơn hàng cùng danh sách sản phẩm chi tiết
        void AddOrder(Order order, List<OrderDetail> details);
    }
}