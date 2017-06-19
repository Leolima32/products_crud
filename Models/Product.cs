using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace products_crud.Models
{
    public class Product {
        [Key]
        public int productId { get; set; }
        public string productName { get; set; }
        public float productRating { get; set; }
        public float productPrice { get; set; }
        public string productDescription { get; set; }
        public string productImagePath { get; set; }
        public virtual List<CategoryProducts> CategoryProducts { get; set; }

        [NotMapped]
        public List<Category> Categories { get; set; }

    }
}