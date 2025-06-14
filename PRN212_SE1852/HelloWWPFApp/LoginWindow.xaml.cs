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

namespace HelloWWPFApp
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Kiểm tra xem nút "Đăng nhập" có được nhấn hay không
            if (sender == btnDangNhap)
            {   
                // Giả lập kiểm tra tài khoản (bạn có thể thay bằng kiểm tra từ CSDL)
                if (txtUserName.Text == "qui" && txtPassword.Password == "qui")
                {
                    SumWindow sum = new SumWindow();
                    sum.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (sender == btnThoat)
            {
                // Đóng ứng dụng
                this.Close();
            }
        }
    }
}
