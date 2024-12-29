using System.ComponentModel.DataAnnotations;

namespace RefreshTokenDemo
{
    public class ProductModel
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
    }
}
