using System.ComponentModel.DataAnnotations;

namespace Product.Application.Models
{
    public class Sku
    {
        [Required]
        [MaxLength(50)]
        public string skuId { get; set; }

        [MinLength(1)]
        public List<Gtin> gtins { get; set; }

        [Required]
        public Details details { get; set; }

        [Required]
        public SupplyInfo supplyInfo { get; set; }

        [Required]
        [MinLength(1)]
        public List<PriceInfo> pricingInfo { get; set; }

        [Range(0, 99999)]
        public int packageWeight { get; set; }

        public decimal volume { get; set; }
    }
}
