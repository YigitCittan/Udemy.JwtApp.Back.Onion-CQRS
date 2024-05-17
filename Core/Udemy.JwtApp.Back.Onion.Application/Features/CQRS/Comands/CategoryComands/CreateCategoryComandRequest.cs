using MediatR;

namespace Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Comands.CategoryComands
{
    public class CreateCategoryComandRequest : IRequest
    {
        public string? Definition { get; set; }

    }
}
