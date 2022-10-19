using MediatR;
using Microsoft.Extensions.Configuration;
using Product.Application.Features.Products.Commons;

namespace Product.Application.Features.Products.Queries.GetStatus
{
    public class GetStatusHandler : AuthorizationBaseHandler, IRequestHandler<GetStatusCommand, string>
    {
        public GetStatusHandler(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<string> Handle(GetStatusCommand request, CancellationToken cancellationToken)
        {
            var response = await _restClientHelper.PostAsync($"{_baseUrl}/products/status", request, _headers);

            return response;
        }
    }
}
