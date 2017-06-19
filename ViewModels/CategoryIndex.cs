using System.Collections.Generic;
using products_crud.Models;

namespace products_crud.ViewModels
{
    public class CategoryIndex
    {
        public IEnumerable<Product> allProducts { get; set; }
        public Category category { get; set; }
        public IEnumerable<Category> allCategories { get; set; }
    }    
}