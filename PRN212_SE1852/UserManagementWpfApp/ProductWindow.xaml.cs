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
using BussinessObjects;
using Servies;

namespace UserManagementWpfApp
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        private ProductServices ProductServices = new ProductServices();

        public ProductWindow()
        {
            InitializeComponent();
            ProductServices.InitializeDataset();
            lvProduct.ItemsSource = ProductServices.GetProducts();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Product p = new Product();
            p.Id = int.Parse(txtMa.Text);
            p.Name = txtTen.Text;
            p.Quantity = int.Parse(txtSoLuong.Text);
            p.Price = double.Parse(txtGia.Text);
        }
    }
}
