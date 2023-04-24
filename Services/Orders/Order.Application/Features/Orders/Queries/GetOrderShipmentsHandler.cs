using System;
using MediatR;
using Microsoft.Extensions.Configuration;
using Order.Application.Features.Orders.Commands.ConfirmOrders;
using Order.Application.Features.Orders.Commons;

namespace Order.Application.Features.Orders.Queries
{
    public class GetOrderShipmentsHandler : AuthorizationBaseHandler, IRequestHandler<GetOrderShipmentsQuery, string>
    {
        public GetOrderShipmentsHandler(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<string> Handle(GetOrderShipmentsQuery request, CancellationToken cancellationToken)
        {
            var response = await _restClientHelper.PostAsync($"{_baseUrl}/orders/packingList", request, _headers);

            return response;
        }
    }
}

