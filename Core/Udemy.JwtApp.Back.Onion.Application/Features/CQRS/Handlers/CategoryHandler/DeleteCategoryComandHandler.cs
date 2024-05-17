using MediatR;
using Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Comands.CategoryComands;
using Udemy.JwtApp.Back.Onion.Application.Interfaces;
using Udemy.JwtApp.Back.Onion.Domain;


namespace Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Handlers.CategoryHandler
{
    public class DeleteCategoryComandHandler : IRequestHandler<DeleteCategoryComandRequest>
    {
        private readonly IRepository<Category> _repository;

        public DeleteCategoryComandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteCategoryComandRequest request, CancellationToken cancellationToken)
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
