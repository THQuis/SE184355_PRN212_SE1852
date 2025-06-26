using System.Windows;
using BusinessObjects;

namespace TruongHoangQuiWFP
{
    /// <summary>
    /// Interaction logic for CustomerDialog.xaml
    /// </summary>
    public partial class CustomerDialog : Window
    {
        public Customer Customer { get; private set; }
        private bool isEdit = false;

        // Constructor cho thêm mới
        public CustomerDialog()
        {
            InitializeComponent();
            Customer = new Customer();
        }

        // Constructor cho sửa (truyền customer cũ vào)
        public CustomerDialog(Customer customer) : this()
        {
            if (customer != null)
            {
                Customer = new Customer
                {
                    CustomerID = customer.CustomerID,
                    CompanyName = customer.CompanyName,
                    ContactName = customer.ContactName,
                    Phone = customer.Phone,
                };
                isEdit = true;
                txtCompanyName.Text = Customer.CompanyName;
                txtContactName.Text = Customer.ContactName;
                txtPhone.Text = Customer.Phone;
            }
        }

        // Nút Lưu
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCompanyName.Text) ||
                string.IsNullOrWhiteSpace(txtContactName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            Customer.CompanyName = txtCompanyName.Text.Trim();
            Customer.ContactName = txtContactName.Text.Trim();
            Customer.Phone = txtPhone.Text.Trim();

            DialogResult = true;
        }

        // Nút Hủy
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}