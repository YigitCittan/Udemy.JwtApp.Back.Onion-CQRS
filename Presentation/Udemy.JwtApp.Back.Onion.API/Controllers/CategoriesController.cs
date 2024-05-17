using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Comands.CategoryComands;
using Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Queries.CategoryQueries;

namespace Udemy.JwtApp.Back.Onion.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var result = await _mediator.Send(new GetCategoriesQueryRequest());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _mediator.Send(new GetCategoryQueryRequest(id));
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryComandRequest request)
        {
            await _mediator.Send(request);
            return Created("", request);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(UpdateCategoryComandRequest request)
        {
            await _mediator.Send(request);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteCategoryComandRequest(id));
            return Ok();
        }
    }
    
}
