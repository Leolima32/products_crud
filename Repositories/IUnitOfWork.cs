using products_crud.Models;

namespace products_crud.Repositories
{
    public interface IUnitOfWork
    {
        IProductsRepository Product { get; }
        ICategoriesRepository Category { get; }
        void Commit();
    }
}