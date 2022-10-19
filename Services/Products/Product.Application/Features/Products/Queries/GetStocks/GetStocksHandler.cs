using MediatR;
using Microsoft.Extensions.Configuration;
using Product.Application.Features.Products.Commons;

namespace Product.Application.Features.Products.Queries.GetStocks
{
    public class GetStocksHandler : AuthorizationBaseHandler, IRequestHandler<GetStocksCommand, string>
    {
        public GetStocksHandler(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<string> Handle(GetStocksCommand request, CancellationToken cancellationToken)
        {
            var response = await _restClientHelper.PostAsync($"{_baseUrl}/products/stock", request, _headers);

            return response;
        }
    }
}
