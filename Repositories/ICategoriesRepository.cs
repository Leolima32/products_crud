using products_crud.Models;
using System.Collections.Generic;

namespace products_crud.Repositories
{
    public interface ICategoriesRepository
    {
        IEnumerable<Category> GetAllCategories();
        Category GetCategoryById(int categoryId);
        void Add(Category category);
    }
}