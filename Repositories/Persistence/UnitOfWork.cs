using products_crud.Context;

namespace products_crud.Repositories.Persistence
{
    public class UnitOfWork: IUnitOfWork
    {
        private IProductsRepository _productsRepository;
        private ICategoriesRepository _categoryRepository;
        private readonly ProductsContext _db;
        public UnitOfWork(ProductsContext db) { _db = db; }

        public IProductsRepository Product {
            get {
                if(_productsRepository == null){
                   _productsRepository = new ProductsRepository(_db);
                }
                return _productsRepository;
            }
        }

        public ICategoriesRepository Category{
            get {
                if(_categoryRepository == null) {
                    _categoryRepository = new CategoriesRepository(_db);
                }
                return _categoryRepository;
            }
        }

        public void Commit() {
            _db.SaveChanges();
        }
    }
}