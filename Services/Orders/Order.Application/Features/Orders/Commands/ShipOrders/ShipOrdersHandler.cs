using System;
using MediatR;
using Microsoft.Extensions.Configuration;
using Order.Application.Features.Orders.Commands.ReturnOrders;
using Order.Application.Features.Orders.Commons;

namespace Order.Application.Features.Orders.Commands.ShipOrders
{
    public class ShipOrdersHandler : AuthorizationBaseHandler, IRequestHandler<ShipOrdersCommand, string>
    {
        public ShipOrdersHandler(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<string> Handle(ShipOrdersCommand request, CancellationToken cancellationToken)
        {
            var response = await _restClientHelper.PostAsync($"{_baseUrl}/orders/ship", request, _headers);

            return response;
        }
    }
}

