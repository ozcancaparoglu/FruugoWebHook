using System.ComponentModel.DataAnnotations;

namespace Product.Application.Models
{
    public class DiscountPrice
    {
        [Required]
        public decimal price { get; set; }

        [Required]
        public bool vatInclusive { get; set; }

        public string startDate { get; set; }

        public string endDate { get; set; }
    }
}
