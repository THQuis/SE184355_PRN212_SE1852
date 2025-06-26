using System;
using System.Windows;
using BusinessObjects;
using Services;
using System.Collections.Generic;


namespace TruongHoangQuiWFP
{
    public partial class ProductDialog : Window
    {

        public Product Product { get; private set; }
        private bool isEdit = false;
        private readonly ICategoryServices categoryServices;
        private List<Category> categories;
        // Thêm mới
        public ProductDialog()
        {
            InitializeComponent();
            Product = new Product();

            categoryServices = new CategoryServices();
            categories = categoryServices.GetAllCategories();
            cbCategory.ItemsSource = categories;
        }


        // Sửa
        public ProductDialog(Product product) : this()
        {
            if (product != null)
            {
                Product = new Product
                {
                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    CategoryID = product.CategoryID,
                    UnitPrice = product.UnitPrice,
                    UnitsInStock = product.UnitsInStock,
                    QuantityPerUnit = product.QuantityPerUnit,
                    UnitsOnOrder = product.UnitsOnOrder,
                    ReorderLevel = product.ReorderLevel,
                    Discontinued = product.Discontinued
                };

                isEdit = true;
                txtProductName.Text = Product.ProductName;
                cbCategory.SelectedValue = Product.CategoryID;
                txtUnitPrice.Text = Product.UnitPrice.ToString();
                txtUnitsInStock.Text = Product.UnitsInStock.ToString();
                txtQuantityPerUnit.Text = Product.QuantityPerUnit;
                txtUnitsOnOrder.Text = Product.UnitsOnOrder.ToString();
                txtReorderLevel.Text = Product.ReorderLevel.ToString();
                chkDiscontinued.IsChecked = Product.Discontinued;
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(txtUnitPrice.Text) ||
                string.IsNullOrWhiteSpace(txtCategoryID.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc.");
                return;
            }

            try
            {
                Product.ProductName = txtProductName.Text.Trim();
                if (cbCategory.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn danh mục!");
                    return;
                }

                Product.CategoryID = (int)cbCategory.SelectedValue;
                Product.Category = cbCategory.SelectedItem as Category;

                Product.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                Product.UnitsInStock = int.Parse(txtUnitsInStock.Text);
                Product.UnitsOnOrder = int.Parse(txtUnitsOnOrder.Text);
                Product.ReorderLevel = int.Parse(txtReorderLevel.Text);
                Product.QuantityPerUnit = txtQuantityPerUnit.Text.Trim();
                Product.Discontinued = chkDiscontinued.IsChecked == true;

                DialogResult = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi định dạng dữ liệu: " + ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
