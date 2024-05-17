using MediatR;

namespace Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Comands.ProductComands
{
    public class DeleteProductComandRequest : IRequest
    {
        public int Id { get; set; }
        public DeleteProductComandRequest(int id)
        {
            Id = id;
        }
    }
}
