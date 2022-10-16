using MediatR;
using Product.Application.Features.Products.Commons;
using Product.Application.Models;
using System.ComponentModel.DataAnnotations;

namespace Product.Application.Features.Products.Commands.CreateOrUpdateProduct
{
    public class CreateOrUpdateProductCommand : IRequest<string>
    {
        public List<Ahmet> products { get; set; }
    }

    public class Ahmet
    {
        public Models.Product product { get; set; }

        [MaxLength(100)]
        [MinLength(1)]
        public List<Sku> skus { get; set; }

    }
}
