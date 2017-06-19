using products_crud.Models;
using System.Collections.Generic;

namespace products_crud.Repositories
{
    public interface ICategoryProductsRepository
    {
        IEnumerable<CategoryProducts> Get();
        void Add(CategoryProducts categoryProducts);
        
        IEnumerable<CategoryProducts> GetCategoriesProductsPerProductId(int productId);
    }
}