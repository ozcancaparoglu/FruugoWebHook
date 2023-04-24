using System;
using MediatR;
using Microsoft.Extensions.Configuration;
using Order.Application.Features.Orders.Commands.GetOrders;
using Order.Application.Features.Orders.Commons;

namespace Order.Application.Features.Orders.Commands.ConfirmOrders
{
    public class ConfirmOrdersHandler : AuthorizationBaseHandler, IRequestHandler<ConfirmOrdersCommand, string>
    {
        public ConfirmOrdersHandler(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<string> Handle(ConfirmOrdersCommand request, CancellationToken cancellationToken)
        {
            var response = await _restClientHelper.PostAsync($"{_baseUrl}/orders/confirm", request, _headers);

            return response;
        }
    }
}

