using products_crud.Models;

namespace products_crud.Repositories
{
    public interface IUnitOfWork
    {
        IProductsRepository Product { get; }
        ICategoriesRepository Category { get; }
        ICategoryProductsRepository CategoryProducts { get; }
        IProductReviewRepository ProductReview { get; }
        void Commit();
    }
}