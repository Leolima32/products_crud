using System.ComponentModel.DataAnnotations;

namespace products_crud.Models
{
    public class Product {
        [Key]
        public int productId { get; set; }
        public string productName { get; set; }
        public int rating { get; set; }
        public int categoryId { get; set; }
    }

}