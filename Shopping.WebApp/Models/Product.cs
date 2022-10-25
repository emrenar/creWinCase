using System.ComponentModel.DataAnnotations;

namespace Shopping.WebApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public string ProductImage { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public double Rating { get; set; }

        public double DiscountPercentage { get; set; }

        public string? Brand { get; set; }

        public Category? Category { get; set; }
        public int CategoryId { get; set; }
    }
}
