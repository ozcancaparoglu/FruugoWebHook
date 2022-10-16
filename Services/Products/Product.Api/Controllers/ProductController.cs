using MediatR;
using Microsoft.AspNetCore.Mvc;
using Product.Application.Features.Products.Commands.CreateOrUpdateProduct;
using System.Net;

namespace Product.Api.Controllers
{
    [Route("products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost("createOrUpdate")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<string>> CreateOrUpdate([FromBody] CreateOrUpdateProductCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
