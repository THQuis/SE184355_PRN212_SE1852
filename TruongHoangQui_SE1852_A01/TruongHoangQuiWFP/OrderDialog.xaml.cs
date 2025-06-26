using System;
using System.Collections.Generic;
using System.Windows;
using BusinessObjects;

namespace TruongHoangQuiWFP
{
    public partial class OrderDialog : Window
    {
        public Order Order { get; private set; }
        public List<OrderDetail> OrderDetails { get; private set; }

        public OrderDialog()
        {
            InitializeComponent();
            Order = new Order();
            OrderDetails = new List<OrderDetail>();
            dpOrderDate.SelectedDate = DateTime.Now;
        }

        private void BtnAddDetail_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var detail = new OrderDetail
                {
                    ProductID = int.Parse(txtProductID.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Discount = float.Parse(txtDiscount.Text)
                };

                OrderDetails.Add(detail);
                dgDetails.ItemsSource = null;
                dgDetails.ItemsSource = OrderDetails;

                // Clear fields
                txtProductID.Clear();
                txtUnitPrice.Clear();
                txtQuantity.Clear();
                txtDiscount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập chi tiết: " + ex.Message);
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Order.CustomerID = int.Parse(txtCustomerID.Text);
                Order.EmployeeID = int.Parse(txtEmployeeID.Text);
                Order.OrderDate = dpOrderDate.SelectedDate ?? DateTime.Now;

                if (OrderDetails.Count == 0)
                {
                    MessageBox.Show("Vui lòng thêm ít nhất 1 sản phẩm.");
                    return;
                }

                DialogResult = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi dữ liệu: " + ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
