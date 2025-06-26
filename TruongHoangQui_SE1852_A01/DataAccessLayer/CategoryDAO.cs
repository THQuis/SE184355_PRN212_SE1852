using System.Collections.Generic;
using System.Linq;
using BusinessObjects;

namespace DataAccessLayer
{
    public static class CategoryDAO
    {
        private static readonly List<Category> Categories = new List<Category>();

        static CategoryDAO()
        {
            InitializeDataset();
        }

        private static void InitializeDataset()
        {
            if (!Categories.Any())
            {
                Categories.AddRange(new List<Category>
                {
                    new Category { CategoryID = 1, CategoryName = "Đồ uống", Description = "Nước uống, cà phê, trà" },
                    new Category { CategoryID = 2, CategoryName = "Thực phẩm", Description = "Bánh kẹo, thực phẩm khô" },
                    new Category { CategoryID = 3, CategoryName = "Gia dụng", Description = "Hàng gia dụng, tiêu dùng" }
                });
            }
        }

        public static List<Category> GetAllCategories()
        {
            return Categories;
        }

        public static Category? GetCategoryById(int id)
        {
            return Categories.FirstOrDefault(c => c.CategoryID == id);
        }
    }
}