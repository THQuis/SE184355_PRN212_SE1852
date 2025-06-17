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
    /// Interaction logic for SumWindow.xaml
    /// </summary>
    public partial class SumWindow : Window
    {
        public SumWindow()
        {
            InitializeComponent();
        }

        private void BtnTong_OnClick(object sender, RoutedEventArgs e)
        {

            int a = int.Parse(txtA.Text);
            int b = int .Parse(txtB.Text);
            int Tong = a + b;
            tbKetQua.Text = Tong + "";
        }

        private void BtnThoat_OnClick(object sender, RoutedEventArgs e)
        {
           Close();
        }
    }
}
