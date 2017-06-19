using System.Collections.Generic;
using products_crud.Models;

namespace products_crud.ViewModels
{
    public class ProductIndex
    {
        public IEnumerable<Product> allProducts { get; set; }
        public IEnumerable<Category> allCategories { get; set; }
    }    
}