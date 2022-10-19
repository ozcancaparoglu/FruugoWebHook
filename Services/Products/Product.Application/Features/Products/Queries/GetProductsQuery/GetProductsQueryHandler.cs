using MediatR;
using Microsoft.Extensions.Configuration;
using Product.Application.Features.Products.Commons;

namespace Product.Application.Features.Products.Queries.GetProductsQuery
{
    public class GetProductsQueryHandler : AuthorizationBaseHandler, IRequestHandler<GetProductsQueryCommand, string>
    {
        public GetProductsQueryHandler(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<string> Handle(GetProductsQueryCommand request, CancellationToken cancellationToken)
        {
            var response = await _restClientHelper.PostAsync($"{_baseUrl}/products/query", request, _headers);

            return response;
        }
    }
}
