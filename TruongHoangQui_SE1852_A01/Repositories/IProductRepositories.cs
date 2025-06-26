using System.Collections.Generic;
using BusinessObjects;

namespace Repositories
{
    public interface IProductRepositories
    {
        // Lấy tất cả sản phẩm
        List<Product> GetAllProducts();

        // Tìm theo ID
        Product? GetProductById(int id);

        // Thêm sản phẩm mới
        void AddProduct(Product product);

        // Cập nhật sản phẩm
        void UpdateProduct(Product product);

        // Xóa sản phẩm
        void DeleteProduct(int id);

        // Tìm kiếm theo tên sản phẩm
        List<Product> SearchProducts(string keyword);
    }
}