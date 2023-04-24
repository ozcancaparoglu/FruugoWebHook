using System;
using MediatR;
using Microsoft.Extensions.Configuration;
using Order.Application.Features.Orders.Commands.ConfirmOrders;
using Order.Application.Features.Orders.Commons;

namespace Order.Application.Features.Orders.Commands.CancelOrders
{
    public class CancelOrdersHandler : AuthorizationBaseHandler, IRequestHandler<CancelOrdersCommand, string>
    {
        public CancelOrdersHandler(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<string> Handle(CancelOrdersCommand request, CancellationToken cancellationToken)
        {
            var response = await _restClientHelper.PostAsync($"{_baseUrl}/orders/cancel", request, _headers);

            return response;
        }
    }
}

