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

namespace ListWPF
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

        private List<int> dsDuLieu = new List<int>();

        private void BtnThem_OnClick(object sender, RoutedEventArgs e)
        {
            //x là giá trị muốn đưa vào cuối dnah sách
            int x = int.Parse(txtGiaTri.Text);
            //them x vào ds:
            dsDuLieu.Add(x);
            HienThiDanhSach();
            txtGiaTri.Text = "";
        }

        //Hàm hiển thị ds lên giao diện
        private void HienThiDanhSach()
        {
            lstDuLieu.Items.Clear();
            for (int i = 0; i < dsDuLieu.Count; i++)
            {
                int x = dsDuLieu[i];
                lstDuLieu.Items.Add(x);
            }
        }

        private void BtnSapXepTang_OnClick(object sender, RoutedEventArgs e)
        {
            //gọi lệnh sắp xếp danh sách:
            dsDuLieu.Sort();
            //hiên thị ds
            HienThiDanhSach();
        }

        private void BtnSapXepGiam_OnClick(object sender, RoutedEventArgs e)
        {
            //gọi lệnh sắp xếp tăng:
            dsDuLieu.Sort();
            //Đảo lại ds
            dsDuLieu.Reverse();
            //hiên thị ds
            HienThiDanhSach();
        }

        private void BtnXoa1PhanTu_OnClick(object sender, RoutedEventArgs e)
        {
            if (lstDuLieu.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chọn phần tử mới xóa được",
                    "Thông báo lỗi",MessageBoxButton.OK);
                return;
            }
            //Xóa phần tử tại vị trí đang chọn:
            dsDuLieu.RemoveAt(lstDuLieu.SelectedIndex);
            HienThiDanhSach();


        }

        private void BtnXoaNhieuPhanTu_OnClick(object sender, RoutedEventArgs e)
        {
            if (lstDuLieu.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chọn phần tử mới xóa được",
                    "Thông báo lỗi", MessageBoxButton.OK);
                return;
            }
            //vòng lặp lấy các phần tử dc chọn trên giao diện
            while (lstDuLieu.SelectedItems.Count>0)
            {
                //lấy ptu đàu tiên ra
                int data = (int)lstDuLieu.SelectedItems[0];
                //Xóa khỏi ds
                dsDuLieu.Remove(data);
                //Xóa dữ liệu trên giao diện
                lstDuLieu.Items.Remove(data);
            }

        }

        private void BtnXoaToanBoPhanTu_OnClick(object sender, RoutedEventArgs e)
        {
           dsDuLieu.Clear();
            HienThiDanhSach();
        }

        private void BtnChen_OnClick(object sender, RoutedEventArgs e)
        {
            //x là giá trị muốn chèn
            int x = int.Parse(txtGiaTriChen.Text);
            //vt mà ta chèn x vào
            int vt = int.Parse((txtViTriChen.Text));
            //chèn x vào vị trí vt
            dsDuLieu.Insert(vt, x);
            //hiển thị lại ds
            HienThiDanhSach();
            txtViTriChen.Text = "";
            txtGiaTriChen.Text = "";
        }
    }
}