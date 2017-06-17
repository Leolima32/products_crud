using products_crud.Context;

namespace products_crud.Repositories.Persistence
{
    public class UnitOfWork: IUnitOfWork
    {
        private IProductsRepository _productsRepository;
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
        public void Commit() {
            _db.SaveChanges();
        }
    }
}