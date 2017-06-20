using System.Collections.Generic;
using System.Linq;
using products_crud.Context;
using products_crud.Models;

namespace products_crud.Repositories.Persistence
{
    public class ProductReviewRepository: IProductReviewRepository {
        private readonly ProductsContext _db;
        public ProductReviewRepository (ProductsContext db) { _db = db; }
        public IEnumerable<ProductReview> getProductReviewsPerProduct(int productId){
            return _db.ProductReviews.Where(x => x.productId == productId);
        }
        public void AddReview(ProductReview producReview) {
            _db.ProductReviews.Add(producReview);
        }
    }


}





