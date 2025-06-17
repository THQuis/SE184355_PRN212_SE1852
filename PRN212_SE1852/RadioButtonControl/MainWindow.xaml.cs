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

namespace RadioButtonControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnHuy_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void BtnGui_OnClick(object sender, RoutedEventArgs e)
        {
            string binhChon = "";
            if (radRatTot.IsChecked == true)
            {
                binhChon = radRatTot.Content + "";
            }
            else if (radTot.IsChecked== true)
            {
                binhChon = radTot.Content + "";
            }
            else if(radTamDuoc.IsChecked == true)
            {
                binhChon
                    = radTamDuoc.Content + "";
            }else if (radKhongTot.IsChecked == true)
            {
                binhChon = radKhongTot.Content + "";
            }

            string gioiTinh = "";
            if (radNam.IsChecked == true)
            {
                gioiTinh = radNam.Content + "";
            } else if (radNu.IsChecked == true)
            {
                gioiTinh
                    = radNu.Content + "";
            }

            string infor = "Bạn bình chọn Hệ Thống=" + binhChon + Environment.NewLine;
            infor += "Giới tính của ban=" + gioiTinh;
            MessageBoxResult ret;
            ret = MessageBox.Show(infor, "Mời bạn xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (ret == MessageBoxResult.Yes)
            {
                //gửi xử lí xác nhận
                MessageBox.Show("Cảm ơn bạn đã gửi phản hồi!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }



        }
    }
}