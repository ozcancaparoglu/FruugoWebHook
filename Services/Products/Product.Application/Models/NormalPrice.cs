using System.ComponentModel.DataAnnotations;

namespace Product.Application.Models
{
    public class NormalPrice
    {
        [Required]
        public double price { get; set; }

        [Required]
        public bool vatInclusive { get; set; }
    }
}
