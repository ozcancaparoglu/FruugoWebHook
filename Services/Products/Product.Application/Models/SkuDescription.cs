using System.ComponentModel.DataAnnotations;

namespace Product.Application.Models
{
    public class SkuDescription
    {
        [Required]
        [MaxLength(2)]
        [MinLength(2)]
        public string language { get; set; }

        [Required]
        [MaxLength(150)]
        [MinLength(1)]
        public string title { get; set; }

        [Required]
        [MaxLength(5000)]
        [MinLength(1)]
        public string text { get; set; }

        public List<Attribute> attributes { get; set; }
    }
}
