using System.ComponentModel.DataAnnotations;

namespace Product.Application.Models
{
    public class Gtin
    {
        [Required]
        public string codeType { get; set; }

        [Required]
        [MaxLength(14)]
        public string code { get; set; }
    }
}
