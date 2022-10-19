using MediatR;
using Microsoft.Extensions.Configuration;
using Product.Application.Features.Products.Commons;

namespace Product.Application.Features.Products.Commands.PartialUpdateProduct
{
    public class PartialUpdateProductHandler : AuthorizationBaseHandler, IRequestHandler<PartialUpdateProductCommand, string>
    {
        public PartialUpdateProductHandler(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<string> Handle(PartialUpdateProductCommand request, CancellationToken cancellationToken)
        {
            var response = await _restClientHelper.PostAsync($"{_baseUrl}/products/partial", request, _headers);

            return response;
        }
    }
}
