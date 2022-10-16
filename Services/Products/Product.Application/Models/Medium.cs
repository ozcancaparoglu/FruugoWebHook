using System.ComponentModel.DataAnnotations;

namespace Product.Application.Models
{
    public class Medium
    {
        [MaxLength(50)]
        public string description { get; set; }

        [Required]
        [MaxLength(150)]
        public string url { get; set; }

        [Required]
        public string type { get; set; }
    }
}
