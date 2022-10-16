using System.ComponentModel.DataAnnotations;

namespace Product.Application.Models
{
    public class PriceInfo
    {
        [Range(0, 100)]
        public int vatRate { get; set; }

        [Required]
        [MaxLength(3)]
        [MinLength(3)]
        public string currency { get; set; }

        public List<string> country { get; set; }

        [Required]
        public NormalPrice normalPrice { get; set; }

        public DiscountPrice discountPrice { get; set; }
    }
}
