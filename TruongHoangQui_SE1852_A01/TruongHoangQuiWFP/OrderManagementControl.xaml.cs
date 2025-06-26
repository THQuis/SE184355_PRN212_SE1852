using System.Windows;
using System.Windows.Controls;
using Services;
using BusinessObjects;
using System.Collections.Generic;

namespace TruongHoangQuiWFP
{
    public partial class OrderManagementControl : UserControl
    {
        private readonly IOrderServices orderServices;

        public OrderManagementControl()
        {
            InitializeComponent();
            orderServices = new OrderServices();
            LoadOrders();
        }

        private void LoadOrders()
        {
            dgOrders.ItemsSource = null;
            dgOrders.ItemsSource = orderServices.GetAllOrders();
            dgOrderDetails.ItemsSource = null;
        }

        private void dgOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgOrders.SelectedItem is Order selectedOrder)
            {
                var details = orderServices.GetOrderDetails(selectedOrder.OrderID);
                dgOrderDetails.ItemsSource = details;
            }
        }

        private void BtnAddOrder_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OrderDialog(); // bạn cần tạo OrderDialog riêng
            if (dialog.ShowDialog() == true)
            {
                orderServices.AddOrder(dialog.Order, dialog.OrderDetails);
                LoadOrders();
            }
        }
    }
}