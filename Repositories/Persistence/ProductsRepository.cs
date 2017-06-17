using System.Collections.Generic;
using products_crud.Context;
using products_crud.Models;

namespace products_crud.Repositories.Persistence
{
    public class ProductsRepository: IProductsRepository {
        private readonly ProductsContext _db;
        public ProductsRepository (ProductsContext db) { _db = db; }

        public IEnumerable<Product> GetProducts() {
            return _db.Products;
        } 
        public void Add (Product product) {
            _db.Products.Add(product);
        }
    }
}