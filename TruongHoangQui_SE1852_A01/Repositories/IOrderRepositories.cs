using System.Collections.Generic;
using BusinessObjects;

namespace Repositories
{
    public interface IOrderRepositories
    {
        // Lấy toàn bộ đơn hàng
        List<Order> GetAllOrders();

        // Lấy đơn hàng theo ID
        Order? GetOrderById(int id);

        // Lấy chi tiết đơn hàng theo OrderID
        List<OrderDetail> GetOrderDetails(int orderId);

        // Tạo đơn hàng mới (gồm cả danh sách sản phẩm)
        void AddOrder(Order order, List<OrderDetail> details);
    }
}