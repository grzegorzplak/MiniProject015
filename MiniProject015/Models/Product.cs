using System.ComponentModel.DataAnnotations;

namespace MiniProject015.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0, 1000)]
        public decimal Price { get; set; }
    }
}
