using System.ComponentModel.DataAnnotations;

namespace Product.Application.Models
{
    public class Attribute
    {
        [MaxLength(30)]
        public string name { get; set; }

        [MaxLength(30)]
        public string value { get; set; }

    }
}
