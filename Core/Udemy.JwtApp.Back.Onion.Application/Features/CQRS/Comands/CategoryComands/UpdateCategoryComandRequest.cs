using MediatR;

namespace Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Comands.CategoryComands
{
    public class UpdateCategoryComandRequest : IRequest
    {
        public int Id { get; set; }
        public string? Definition { get; set; }
    }
}
