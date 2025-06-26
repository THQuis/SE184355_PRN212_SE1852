using System.Collections.Generic;
using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class CategoryRepositories : ICategoryRepositories
    {
        // Singleton pattern (optional)
        private static CategoryRepositories? instance = null;
        private static readonly object instanceLock = new object();

        public static CategoryRepositories Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CategoryRepositories();
                    }
                    return instance;
                }
            }
        }

        private CategoryRepositories() { }

        public List<Category> GetAllCategories()
        {
            return CategoryDAO.GetAllCategories();
        }

        public Category? GetCategoryById(int id)
        {
            return CategoryDAO.GetCategoryById(id);
        }
    }
}