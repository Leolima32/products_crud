using System.Collections.Generic;
using System.Linq;
using products_crud.Context;
using products_crud.Models;

namespace products_crud.Repositories.Persistence
{
    internal class CategoriesRepository : ICategoriesRepository
    {
        private readonly ProductsContext _db;
        public CategoriesRepository(ProductsContext db)
        {
            _db = db;
        }
        public IEnumerable<Category> GetAllCategories()
        {
            try
            {
                return _db.Categories.ToList();
            }
            catch (System.Exception ex)
            {
                
                throw ex;
            }
            
        }
        public Category GetCategoryById(int categoryId)
        {
            return _db.Categories.FirstOrDefault(x => x.categoryId == categoryId);
        }
        public void Add (Category category) {
            _db.Categories.Add(category);
        }
    }
}