using System.ComponentModel.DataAnnotations;

namespace Product.Application.Models
{
    public class Details
    {
        [MinLength(1)]
        public List<SkuDescription> skuDescriptions { get; set; }

        [MaxLength(5)]
        [MinLength(1)]
        public List<Medium> media { get; set; }
    }
}
