using System.Collections.Generic;
using products_crud.Models;

namespace products_crud.Repositories {
    public interface IProductReviewRepository {
        IEnumerable<ProductReview> getProductReviewsPerProduct(int productId);
        void AddReview(ProductReview producReview);
    }
}
