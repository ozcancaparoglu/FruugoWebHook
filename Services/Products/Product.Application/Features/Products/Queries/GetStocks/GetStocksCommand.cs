using MediatR;
using Product.Application.Features.Products.ValueObjects;

namespace Product.Application.Features.Products.Queries.GetStocks
{
    public class GetStocksCommand : IRequest<string>
    {
        public List<SkuFilter> skus { get; set; }
    }
}
