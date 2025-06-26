using System.Windows;
using System.Windows.Controls;
using BusinessObjects;
using Services;

namespace TruongHoangQuiWFP
{
    public partial class ProfileControl : UserControl
    {
        private readonly ICustomerServices customerServices;
        private Customer customer;

        public ProfileControl(Customer currentCustomer)
        {
            InitializeComponent();
            customerServices = new CustomerServices();
            customer = currentCustomer;

            // Hiển thị dữ liệu ban đầu
            txtCompanyName.Text = customer.CompanyName;
            txtContactName.Text = customer.ContactName;
            txtPhone.Text = customer.Phone;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCompanyName.Text) ||
                string.IsNullOrWhiteSpace(txtContactName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            // Cập nhật thông tin
            customer.CompanyName = txtCompanyName.Text.Trim();
            customer.ContactName = txtContactName.Text.Trim();
            customer.Phone = txtPhone.Text.Trim();

            customerServices.UpdateCustomer(customer);
            MessageBox.Show("Cập nhật hồ sơ thành công!");
        }
    }
}