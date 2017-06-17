namespace products_crud.Models
{
    public class Product {
        public int productId { get; set; }
        public string productName { get; set; }
        public int Rating { get; set; }
        public int categoryId { get; set; }
        public Category Category { get; set; }
    }

}