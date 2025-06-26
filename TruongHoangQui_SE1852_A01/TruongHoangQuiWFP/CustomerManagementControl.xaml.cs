using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using BusinessObjects;
using Services;

namespace TruongHoangQuiWFP
{
    public partial class CustomerManagementControl : UserControl
    {
        private readonly ICustomerServices customerServices;

        public CustomerManagementControl()
        {
            InitializeComponent();
            customerServices = new CustomerServices();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            dgCustomers.ItemsSource = null;
            dgCustomers.ItemsSource = customerServices.GetAllCustomers();
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            List<Customer> result = string.IsNullOrEmpty(keyword)
                ? customerServices.GetAllCustomers()
                : customerServices.SearchCustomers(keyword);
            dgCustomers.ItemsSource = null;
            dgCustomers.ItemsSource = result;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new CustomerDialog();
            if (dialog.ShowDialog() == true)
            {
                customerServices.AddCustomer(dialog.Customer);
                LoadCustomers();
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (dgCustomers.SelectedItem is Customer selected)
            {
                var dialog = new CustomerDialog(selected);
                if (dialog.ShowDialog() == true)
                {
                    customerServices.UpdateCustomer(dialog.Customer);
                    LoadCustomers();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để sửa.");
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dgCustomers.SelectedItem is Customer selected)
            {
                var result = MessageBox.Show(
                    $"Bạn có chắc muốn xóa khách hàng {selected.ContactName}?",
                    "Xác nhận xóa",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Warning
                );
                if (result == MessageBoxResult.Yes)
                {
                    customerServices.DeleteCustomer(selected.CustomerID);
                    LoadCustomers();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa.");
            }
        }
    }
}