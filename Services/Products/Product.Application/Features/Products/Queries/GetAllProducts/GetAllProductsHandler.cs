using MediatR;
using Microsoft.Extensions.Configuration;
using Product.Application.Features.Products.Commons;

namespace Product.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsHandler : AuthorizationBaseHandler, IRequestHandler<GetAllProductsCommand, string>
    {
        public GetAllProductsHandler(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<string> Handle(GetAllProductsCommand request, CancellationToken cancellationToken)
        {
            var response = await _restClientHelper.PostAsync($"{_baseUrl}/products/all", request, _headers);

            return response;
        }
    }
}
