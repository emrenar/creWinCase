using System.ComponentModel.DataAnnotations;

namespace Shopping.WebApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string? CategoryName { get; set; }

        public List<Product>? Products { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
