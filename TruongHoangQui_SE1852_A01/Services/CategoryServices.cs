using System.Collections.Generic;
using BusinessObjects;
using Repositories;

namespace Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly ICategoryRepositories categoryRepositories;

        public CategoryServices()
        {
            categoryRepositories = CategoryRepositories.Instance;
        }

        public List<Category> GetAllCategories()
        {
            return categoryRepositories.GetAllCategories();
        }

        public Category? GetCategoryById(int id)
        {
            return categoryRepositories.GetCategoryById(id);
        }
    }
}