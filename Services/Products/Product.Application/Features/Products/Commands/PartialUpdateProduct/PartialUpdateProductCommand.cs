using MediatR;
using Product.Application.Features.Products.ValueObjects;

namespace Product.Application.Features.Products.Commands.PartialUpdateProduct
{
    public class PartialUpdateProductCommand : IRequest<string>
    {
        public List<ProductList> products { get; set; }
    }
}
