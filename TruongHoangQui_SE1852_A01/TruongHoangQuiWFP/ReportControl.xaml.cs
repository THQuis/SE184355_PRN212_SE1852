using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using BusinessObjects;
using Services;
using System.Collections.Generic;

namespace TruongHoangQuiWFP
{
    public partial class ReportControl : UserControl
    {
        private readonly IOrderServices orderServices;

        public ReportControl()
        {
            InitializeComponent();
            orderServices = new OrderServices();

            dpFrom.SelectedDate = DateTime.Now.AddMonths(-1);
            dpTo.SelectedDate = DateTime.Now;
        }

        private void BtnReport_Click(object sender, RoutedEventArgs e)
        {
            if (dpFrom.SelectedDate == null || dpTo.SelectedDate == null)
            {
                MessageBox.Show("Vui lòng chọn khoảng thời gian.");
                return;
            }

            DateTime from = dpFrom.SelectedDate.Value;
            DateTime to = dpTo.SelectedDate.Value;

            var orders = orderServices.GetAllOrders()
                .Where(o => o.OrderDate.Date >= from.Date && o.OrderDate.Date <= to.Date)
                .OrderByDescending(o => o.OrderDate)
                .ToList();

            var reportData = new List<dynamic>();
            decimal grandTotal = 0;

            foreach (var order in orders)
            {
                var details = orderServices.GetOrderDetails(order.OrderID);
                decimal total = details.Sum(d => d.UnitPrice * d.Quantity * (1 - (decimal)d.Discount));
                grandTotal += total;

                reportData.Add(new
                {
                    order.OrderID,
                    order.CustomerID,
                    order.EmployeeID,
                    order.OrderDate,
                    TotalAmount = total.ToString("N0") + " đ"
                });
            }

            dgReport.ItemsSource = null;
            dgReport.ItemsSource = reportData;
            txtSummary.Text = $"Tổng số đơn: {orders.Count}, Tổng doanh thu: {grandTotal:N0} đ";
        }
    }
}
