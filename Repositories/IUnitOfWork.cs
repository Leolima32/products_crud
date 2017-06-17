using products_crud.Models;

namespace products_crud.Repositories {
    public interface IUnitOfWork {
        IProductsRepository Product { get; }
        void Add(Product product);
        void Commit();
    }
}