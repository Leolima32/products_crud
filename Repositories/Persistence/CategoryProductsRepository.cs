using System.Collections.Generic;
using System.Linq;
using products_crud.Context;
using products_crud.Models;

namespace products_crud.Repositories.Persistence
{
    public class CategoryProductsRepository : ICategoryProductsRepository
    {
        private readonly ProductsContext _db;
        public CategoryProductsRepository(ProductsContext db) { _db = db; }

        public IEnumerable<CategoryProducts> Get()
        {
            return _db.CategoryProducts;
        }
        public void Add(CategoryProducts categoryProducts)
        {
            _db.CategoryProducts.Add(categoryProducts);
        }

        public IEnumerable<CategoryProducts> GetCategoriesProductsPerProductId(int id) {
            return _db.CategoryProducts.Where(x => x.productId == id);
        }
        public IEnumerable<CategoryProducts> GetCategoriesProductsPerCategoryId(int id) {
            return _db.CategoryProducts.Where(x => x.categoryId == id);
        }
    }
}