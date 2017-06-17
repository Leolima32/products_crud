using System.ComponentModel.DataAnnotations;

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
        public int categoryId { get; set; }
    }

}