using MediatR;
using Product.Application.Features.Products.ValueObjects;

namespace Product.Application.Features.Products.Queries.GetPrices
{
    public class GetPricesCommand : IRequest<string>
    {
        public List<SkuFilter> skus { get; set; }
    }
}
