using System.Collections.Generic;
using BusinessObjects;

namespace Repositories
{
    public interface ICategoryRepositories
    {
        List<Category> GetAllCategories();
        Category? GetCategoryById(int id);
    }
}