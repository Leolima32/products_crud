using products_crud.Models;
using System.Collections.Generic;

namespace products_crud.Repositories
{
    public interface ICategoriesRepository
    {
        List<Category> GetAllCategories();
        Category GetCategoryById(int categoryId);
    }
}