using products_crud.Context;

namespace products_crud.Repositories.Persistence
{
    public class UnitOfWork: IUnitOfWork
    {
        private IProductsRepository _productsRepository;
        private ICategoriesRepository _categoryRepository;
        private ICategoryProductsRepository _categoryProductsRepository;
        private IProductReviewRepository _productReviewRepository;
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

        public ICategoryProductsRepository CategoryProducts {
            get {
                if(_categoryProductsRepository == null) {
                    _categoryProductsRepository = new CategoryProductsRepository(_db);
                }
                return _categoryProductsRepository;
            }
        }

        public IProductReviewRepository ProductReview {
            get {
                if(_productReviewRepository == null) {
                    _productReviewRepository = new ProductReviewRepository(_db);
                }
                return _productReviewRepository;
            }
        }
        public void Commit() {
            _db.SaveChanges();
        }
        public void Close() {
            _db.Dispose();
        }
    }
}