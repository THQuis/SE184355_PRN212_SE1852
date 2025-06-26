using System.Linq;
using System.Windows.Controls;
using BusinessObjects;
using Services;

namespace TruongHoangQuiWFP
{
    public partial class OrderHistoryControl : UserControl
    {
        private readonly IOrderServices orderServices;
        private readonly int customerId;

        public OrderHistoryControl(Customer customer)
        {
            InitializeComponent();
            orderServices = new OrderServices();
            customerId = customer.CustomerID;
            LoadOrderHistory();
        }

        private void LoadOrderHistory()
        {
            var orders = orderServices.GetAllOrders()
                .Where(o => o.CustomerID == customerId)
                .OrderByDescending(o => o.OrderDate)
                .ToList();

            dgOrders.ItemsSource = orders;
            dgDetails.ItemsSource = null;
        }

        private void dgOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgOrders.SelectedItem is Order selected)
            {
                var details = orderServices.GetOrderDetails(selected.OrderID);
                dgDetails.ItemsSource = details;
            }
        }
    }
}