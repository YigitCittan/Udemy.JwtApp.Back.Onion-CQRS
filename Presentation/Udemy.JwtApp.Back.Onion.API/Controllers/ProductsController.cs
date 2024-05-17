using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Comands.ProductComands;
using Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Queries.ProductQueries;


namespace Udemy.JwtApp.Back.Onion.API.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var result = await _mediator.Send(new GetAllProductQueryRequest());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _mediator.Send(new GetProductQueryRequest(id));
            if(result == null)
            { 
                return NotFound();
            }
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteProductComandRequest(id));
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductComandRequest request)
        {
            await _mediator.Send(request);
            return Created("", request);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(UpdateProductComandRequest request)
        {
            await _mediator.Send(request);
            return NoContent();
        }

    }
}
