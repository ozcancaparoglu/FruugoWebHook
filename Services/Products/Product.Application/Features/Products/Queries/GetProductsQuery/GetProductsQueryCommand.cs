using MediatR;
using Product.Application.Features.Products.ValueObjects;

namespace Product.Application.Features.Products.Queries.GetProductsQuery
{
    public class GetProductsQueryCommand : IRequest<string>
    {
        public List<SkuFilter> skus { get; set; }
        public List<ProductFilter> filters { get; set; }
    }
}
