using System.ComponentModel.DataAnnotations;

namespace Product.Application.Models
{
    public class Product
    {
        [Required]
        [MaxLength(50)]
        public string productId { get; set; }

        [MaxLength(50)]
        public string brand { get; set; }

        [MaxLength(50)]
        public string manufacturer { get; set; }

        [Required]
        [MaxLength(250)]
        public string category { get; set; }
    }
}
