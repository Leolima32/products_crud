using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using products_crud.Models;
using products_crud.Repositories;
using Microsoft.AspNetCore.Routing; 

namespace products_crud.Controllers
{
    public class ProductReviewController : Controller {
        private readonly IUnitOfWork _unit;
        public ProductReviewController (IUnitOfWork unit) {
            _unit = unit;
        }
        [HttpGet]
        [Route("ProductReview/getReviews/{productId}")]
        public IEnumerable<ProductReview> getReviews(int productId) {
            return _unit.ProductReview.getProductReviewsPerProduct(productId);
        }
        [HttpPost]
        public bool Add([FromBody]ProductReview review) {
            _unit.ProductReview.AddReview(review);
            _unit.Commit();
            return true;
        }
    }
}