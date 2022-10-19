using Product.Application.Models;
using System.ComponentModel.DataAnnotations;

namespace Product.Application.Features.Products.ValueObjects
{
    public class ProductList
    {
        public Models.Product product { get; set; }

        [MaxLength(100)]
        [MinLength(1)]
        public List<Sku> skus { get; set; }

    }
}
