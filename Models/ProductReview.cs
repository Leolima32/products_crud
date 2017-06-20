namespace products_crud.Models
{
    public class ProductReview {
        public int productReviewId { get; set; }
        public int productId { get; set; }
        public float rating { get; set; }
        public string comment { get; set; }
    }
}