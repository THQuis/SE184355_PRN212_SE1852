using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BusinessObjects;

namespace TruongHoangQuiWFP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Employee currentEmployee;
        private Customer currentCustomer;

        public MainWindow(Employee emp)
        {
            InitializeComponent();
            currentEmployee = emp;
            ShowAdminMenu();
        }

        public MainWindow(Customer cus)
        {
            InitializeComponent();
            currentCustomer = cus;
            ShowCustomerMenu();
        }

        private void ShowAdminMenu()
        {
            // Admin được phép làm mọi chức năng
            menuCustomer.Visibility = Visibility.Visible;
            menuProduct.Visibility = Visibility.Visible;
            menuOrder.Visibility = Visibility.Visible;
            menuReport.Visibility = Visibility.Visible;
            menuOrderHistory.Visibility = Visibility.Collapsed;
            menuProfile.Visibility = Visibility.Collapsed;
        }

        private void ShowCustomerMenu()
        {
            // Customer chỉ xem lịch sử đơn và chỉnh sửa cá nhân
            menuCustomer.Visibility = Visibility.Collapsed;
            menuProduct.Visibility = Visibility.Collapsed;
            menuOrder.Visibility = Visibility.Collapsed;
            menuReport.Visibility = Visibility.Collapsed;
            menuOrderHistory.Visibility = Visibility.Visible;
            menuProfile.Visibility = Visibility.Visible;
        }

        // Xử lý Click các menu: Load UserControl tương ứng vào MainContent

        private void MenuCustomer_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new CustomerManagementControl();
        }

        private void MenuProduct_OnClick(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new ProductManagementControl();
        }
        private void MenuOrder_OnClick(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new OrderManagementControl();
        }
        private void MenuReport_OnClick(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new ReportControl();
        }
        private void MenuOrderHistory_OnClick(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new OrderHistoryControl(currentCustomer);
        }
        private void MenuProfile_OnClick(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new ProfileControl(currentCustomer);
        }

        private void MenuLogout_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                LoginWindow login = new LoginWindow();
                login.Show();
                this.Close();
            }
        }

    }
} 