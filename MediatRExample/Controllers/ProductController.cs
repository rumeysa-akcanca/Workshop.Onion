using MediatR;
using MediatRExample.CQRS.Command.Request;
using MediatRExample.CQRS.Command.Response;
using MediatRExample.CQRS.Query.Request;
using MediatRExample.CQRS.Query.Response;
using Microsoft.AspNetCore.Mvc;

namespace MediatRExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllProductQueryRequest requestmodel)
        {
            List<GetAllProductQueryResponse> allProduct = await _mediator.Send(requestmodel);
            return Ok(allProduct);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromQuery] GetByIdProductQueryRequest requestmodel)
        {
            GetByIdProductQueryResponse product = await _mediator.Send(requestmodel);
            return Ok(product);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateProductCommandRequest requestmodel)
        {
           CreateProductCommandResponse response = await _mediator.Send(requestmodel);
          return Ok(response);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromQuery] DeleteProductCommandRequest requestmodel)
        {
            DeleteProductCommandResponse response = await _mediator.Send(requestmodel);
            return Ok(response);
        }
    }
}
