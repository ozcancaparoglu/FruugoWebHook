using MediatR;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Product.Application.Features.Products.Commons;

namespace Product.Application.Features.Products.Commands.CreateOrUpdateProduct
{
    public class CreateOrUpdateProductHandler : AuthorizationBaseHandler, IRequestHandler<CreateOrUpdateProductCommand, string>
    {
        public CreateOrUpdateProductHandler(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<string> Handle(CreateOrUpdateProductCommand request, CancellationToken cancellationToken)
        {

            var response = await _restClientHelper.PostAsync($"{_baseUrl}/products", request, _headers);

            return response;
        }
    }
}
