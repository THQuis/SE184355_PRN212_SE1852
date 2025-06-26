using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BusinessObjects;
using Services; // Đảm bảo đã using namespace Services

namespace TruongHoangQuiWFP
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        // --- Bắt đầu phần chỉnh sửa ---

        // 1. Khai báo các đối tượng Service mà chúng ta sẽ sử dụng
        // Dùng 'private readonly' để đảm bảo an toàn
        private readonly IEmployeeServices iEmployeeServices;
        private readonly ICustomerServices iCustomerServices;

        // --- Kết thúc phần chỉnh sửa ---

        public LoginWindow()
        {
            InitializeComponent();

            // --- Bắt đầu phần chỉnh sửa ---

            // 2. Khởi tạo các đối tượng Service khi cửa sổ được tạo ra
            iEmployeeServices = new EmployeeServices();
            iCustomerServices = new CustomerServices();

            // --- Kết thúc phần chỉnh sửa ---

            // Đoạn code này của bạn đã đúng, giữ nguyên
            lblUser.Text = rdoAdmin.IsChecked == true ? "Username:" : "Phone:";
        }

        private void Role_Checked(object sender, RoutedEventArgs e)
        {
            // Đoạn code này của bạn đã đúng, giữ nguyên
            if (lblUser == null || txtUsername == null)
                return;

            if (rdoCustomer.IsChecked == true)
            {
                lblUser.Text = "Số điện thoại:";
                lblPassword.Visibility = Visibility.Collapsed;
                txtPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                lblUser.Text = "Username:";
                lblPassword.Visibility = Visibility.Visible;
                txtPassword.Visibility = Visibility.Visible;
            }
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (rdoAdmin.IsChecked == true)
            {
                // Admin/Employee login
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Password; // Không cần Trim() cho PasswordBox

                // --- Bắt đầu phần chỉnh sửa ---

                // 3. Thay thế AuthService bằng đối tượng iEmployeeServices đã khai báo
                Employee? emp = iEmployeeServices.Login(username, password);

                // --- Kết thúc phần chỉnh sửa ---

                if (emp != null)
                {
                    MainWindow main = new MainWindow(emp);
                    main.Show();
                    //MessageBox.Show($"Đăng nhập thành công! Chào mừng {emp.Name}");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu (Admin)!");
                }
            }
            else
            {
                // Customer login
                string phone = txtUsername.Text.Trim();

                // --- Bắt đầu phần chỉnh sửa ---

                // 4. Thay thế AuthService bằng đối tượng iCustomerServices đã khai báo
                Customer? cus = iCustomerServices.Login(phone);

                // --- Kết thúc phần chỉnh sửa ---

                if (cus != null)
                {
                    // Giả sử bạn có một MainWindow nhận vào đối tượng Customer
                    MainWindow main = new MainWindow(cus);
                    main.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai số điện thoại hoặc mật khẩu (Customer)!");
                }
            }
        }

        private void BtnThoat_Click(object sender, RoutedEventArgs e)
        {
            // Đoạn code này của bạn đã đúng, giữ nguyên
            Close();
        }
    }
}
