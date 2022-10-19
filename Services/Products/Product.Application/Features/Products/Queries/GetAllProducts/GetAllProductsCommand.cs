using MediatR;
using Product.Application.Features.Products.ValueObjects;

namespace Product.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsCommand : IRequest<string>
    {
        public List<ProductFilter> filters { get; set; }
    }
}
