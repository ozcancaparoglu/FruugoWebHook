using System;
using MediatR;
using Microsoft.Extensions.Configuration;
using Order.Application.Features.Orders.Commands.CancelOrders;
using Order.Application.Features.Orders.Commons;

namespace Order.Application.Features.Orders.Commands.ReturnOrders
{
    public class ReturnOrdersHandler : AuthorizationBaseHandler, IRequestHandler<ReturnOrdersCommand, string>
    {
        public ReturnOrdersHandler(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<string> Handle(ReturnOrdersCommand request, CancellationToken cancellationToken)
        {
            var response = await _restClientHelper.PostAsync($"{_baseUrl}/orders/return", request, _headers);

            return response;
        }
    }
}

