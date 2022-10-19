using MediatR;
using Microsoft.Extensions.Configuration;
using Product.Application.Features.Products.Commons;

namespace Product.Application.Features.Products.Queries.GetPrices
{
    public class GetPricesHandler : AuthorizationBaseHandler, IRequestHandler<GetPricesCommand, string>
    {
        public GetPricesHandler(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<string> Handle(GetPricesCommand request, CancellationToken cancellationToken)
        {
            var response = await _restClientHelper.PostAsync($"{_baseUrl}/products/priceInfo", request, _headers);

            return response;
        }
    }
}
