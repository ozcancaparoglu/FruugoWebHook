using System.ComponentModel.DataAnnotations;

namespace Product.Application.Models
{
    public class SupplyInfo
    {
        [Required]
        public string stockStatus { get; set; }

        [Range(0, 99999)]
        public int stockQuantity { get; set; }

        [Range(1, 99)]
        public int leadTime { get; set; }

        [DisplayFormat(DataFormatString = "YYYY-MM-DD")]
        public string restockDate { get; set; }
    }
}
