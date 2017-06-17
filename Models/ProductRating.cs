namespace products_crud.Models
{
    public class ProductRating {
        public int productRatingId { get; set; }
        public int productId { get; set; }
        public float rating { get; set; }
    }
}