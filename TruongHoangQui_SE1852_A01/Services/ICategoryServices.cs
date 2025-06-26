using System.Collections.Generic;
using BusinessObjects;

namespace Services
{
    public interface ICategoryServices
    {
        List<Category> GetAllCategories();
        Category? GetCategoryById(int id);
    }
}