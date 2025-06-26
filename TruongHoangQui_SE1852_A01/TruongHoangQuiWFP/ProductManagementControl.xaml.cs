using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using BusinessObjects;
using Services;

namespace TruongHoangQuiWFP
{
    public partial class ProductManagementControl : UserControl
    {
        private readonly IProductServices productServices;

        public ProductManagementControl()
        {
            InitializeComponent();
            productServices = new ProductServices();
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgProducts.ItemsSource = null;
            dgProducts.ItemsSource = productServices.GetAllProducts();
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            List<Product> result = string.IsNullOrEmpty(keyword)
                ? productServices.GetAllProducts()
                : productServices.SearchProducts(keyword);
            dgProducts.ItemsSource = null;
            dgProducts.ItemsSource = result;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new ProductDialog();
            if (dialog.ShowDialog() == true)
            {
                productServices.AddProduct(dialog.Product);
                LoadProducts();
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (dgProducts.SelectedItem is Product selected)
            {
                var dialog = new ProductDialog(selected);
                if (dialog.ShowDialog() == true)
                {
                    productServices.UpdateProduct(dialog.Product);
                    LoadProducts();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để sửa.");
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dgProducts.SelectedItem is Product selected)
            {
                var confirm = MessageBox.Show($"Xoá sản phẩm {selected.ProductName}?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (confirm == MessageBoxResult.Yes)
                {
                    productServices.DeleteProduct(selected.ProductID);
                    LoadProducts();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xoá.");
            }
        }
    }
}
