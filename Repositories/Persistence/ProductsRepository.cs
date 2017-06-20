using System.Collections.Generic;
using System.Linq;
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
        public Product GetProductById(int id) {
            return _db.Products.FirstOrDefault(x => x.productId == id);
        }
    }
}