using MediatR;
using Microsoft.AspNetCore.Mvc;
using Order.Application.Features.Orders.Commands.CancelOrders;
using Order.Application.Features.Orders.Commands.ConfirmOrders;
using Order.Application.Features.Orders.Commands.GetOrders;
using Order.Application.Features.Orders.Commands.ReturnOrders;
using Order.Application.Features.Orders.Commands.ShipOrders;
using System.Net;

namespace Order.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "GetOrders")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<string>> GetOrders([FromBody] GetOrdersCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPost(Name = "ConfirmOrders")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<string>> ConfirmOrders([FromBody] ConfirmOrdersCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPost(Name = "CancelOrders")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<string>> CancelOrders([FromBody] CancelOrdersCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPost(Name = "ReturnOrders")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<string>> ReturnOrders([FromBody] ReturnOrdersCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPost(Name = "ShipOrders")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<string>> ShipOrders([FromBody] ShipOrdersCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

    }
}
