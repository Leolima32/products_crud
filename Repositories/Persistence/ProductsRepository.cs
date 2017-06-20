using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using products_crud.Context;
using products_crud.Models;
using Microsoft.Extensions.Configuration;

namespace products_crud.Repositories.Persistence
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ProductsContext _db;
        public ProductsRepository(ProductsContext db) { _db = db; }

        public IEnumerable<Product> GetProducts()
        {
            return _db.Products;
        }
        public void Add(Product product)
        {
            _db.Products.Add(product);
        }
        public Product GetProductById(int id)
        {
            return _db.Products.FirstOrDefault(x => x.productId == id);
        }
        public IEnumerable<Product> Filter(string filterBy, int categoryId)
        {
            try
            {
                if (string.IsNullOrEmpty(filterBy) && categoryId == 0)
                {
                    return _db.Products;
                }
                else if (categoryId == 0)
                {
                    return _db.Products.Where(x => x.productName.Contains(filterBy));
                }
                else if (string.IsNullOrEmpty(filterBy))
                {
                    IEnumerable<CategoryProducts> categories = _db.CategoryProducts.Where(x => x.categoryId == categoryId);
                    IEnumerable<Product> products = _db.Products.Where(x=> x.productName != null);
                    products = products.Where(x =>categories.Any(y=> y.productId == x.productId));
                    return products;
                }
                else
                {
                    IEnumerable<CategoryProducts> categories = _db.CategoryProducts.Where(x => x.categoryId == categoryId);
                    IEnumerable<Product> products = _db.Products.Where(x=> x.productName.Contains(filterBy));
                    products = products.Where(x =>categories.Any(y=> y.productId == x.productId));
                    return products;
                }
            }
            catch (System.Exception ex)
            {

                throw ex;
            }


        }
    }
}