using System.Collections.Generic;
using products_crud.Models;

namespace products_crud.ViewModels
{
    public class ProductList
    {
        public IEnumerable<Product> productList { get; set; }
        public string category { get; set; }
        public List<Category> disponibleCategories { get; set; }
    }    
}
