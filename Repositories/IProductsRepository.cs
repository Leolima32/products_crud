using System.Collections.Generic;
using products_crud.Models;

namespace products_crud.Repositories {
    public interface IProductsRepository {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
        IEnumerable<Product> Filter(string filterBy, int categoryId);
        void Add(Product product);
    }
}