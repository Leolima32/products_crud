using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace products_crud.Models
{
    public class CategoryProducts {
        public int productId { get; set; }
        public Product Product { get; set; }
        public int categoryId { get; set; }
        public Category Category { get; set; }
    }
}