using MediatR;

namespace Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Comands.CategoryComands
{
    public class DeleteCategoryComandRequest : IRequest
    {
        public int Id { get; set; }
        public DeleteCategoryComandRequest(int id)
        {
            Id = id;
        }
    }
}
