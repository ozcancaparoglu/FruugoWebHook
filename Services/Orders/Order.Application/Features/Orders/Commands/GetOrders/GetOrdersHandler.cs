using MediatR;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Order.Application.Features.Orders.Commons;

namespace Order.Application.Features.Orders.Commands.GetOrders
{
    public class GetOrdersHandler : AuthorizationBaseHandler, IRequestHandler<GetOrdersCommand, string>
    {
        public GetOrdersHandler(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<string> Handle(GetOrdersCommand request, CancellationToken cancellationToken)
        {

            var response = await _restClientHelper.PostAsync($"{_baseUrl}/orders", request, _headers);

            return response;
        }
    }
}
