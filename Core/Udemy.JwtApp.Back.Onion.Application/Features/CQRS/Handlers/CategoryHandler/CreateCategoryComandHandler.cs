using MediatR;
using Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Comands.CategoryComands;
using Udemy.JwtApp.Back.Onion.Application.Interfaces;
using Udemy.JwtApp.Back.Onion.Domain;



namespace Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Handlers.CategoryHandler
{
    public class CreateCategoryComandHandler : IRequestHandler<CreateCategoryComandRequest>
    {
        private readonly IRepository<Category> _repository;

        public CreateCategoryComandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateCategoryComandRequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Category
            {
                Definition = request.Definition,

            });
            return Unit.Value;
        }
    }
}
