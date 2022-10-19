using MediatR;
using Product.Application.Features.Products.ValueObjects;

namespace Product.Application.Features.Products.Queries.GetStatus
{
    public class GetStatusCommand : IRequest<string>
    {
        public List<SkuFilter> skus { get; set; }
    }
}
