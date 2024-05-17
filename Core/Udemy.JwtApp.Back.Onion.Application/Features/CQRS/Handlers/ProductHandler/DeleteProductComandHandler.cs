using MediatR;
using Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Comands.ProductComands;
using Udemy.JwtApp.Back.Onion.Application.Interfaces;
using Udemy.JwtApp.Back.Onion.Domain;


namespace Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Handlers.ProductHandler
{
    public class DeleteProductComandHandler : IRequestHandler<DeleteProductComandRequest>
    {
        private readonly IRepository<Product> _repository;

        public DeleteProductComandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteProductComandRequest request, CancellationToken cancellationToken)
        {
            var deletedEntity = await _repository.GetByIdAsync(request.Id);
            if (deletedEntity != null)
            {
                await _repository.RemoveAsync(deletedEntity);
            }
            return Unit.Value;
        }
    }
}
