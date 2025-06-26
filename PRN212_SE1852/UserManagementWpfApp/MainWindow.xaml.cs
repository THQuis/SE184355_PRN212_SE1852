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
using BussinessObjects;
using Servies;
namespace UserManagementWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        UserServies service = new UserServies();
        public MainWindow()
        {
            InitializeComponent();
            HienThiAllUser();
        }

        private void HienThiAllUser()
        {
            List<User> users = service.GetAllUsers();
            lbUser.ItemsSource = users;

        }

    }
}