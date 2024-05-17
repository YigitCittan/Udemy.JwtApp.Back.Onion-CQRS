using MediatR;
using Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Comands.CategoryComands;
using Udemy.JwtApp.Back.Onion.Application.Interfaces;
using Udemy.JwtApp.Back.Onion.Domain;


namespace Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Handlers.CategoryHandler
{
    public class UpdateCategoryComandHandler : IRequestHandler<UpdateCategoryComandRequest>
    {
        private readonly IRepository<Category> _repository;

        public UpdateCategoryComandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateCategoryComandRequest request, CancellationToken cancellationToken)
        {
            var updatedCategory = await _repository.GetByIdAsync(request.Id);
            if (updatedCategory != null)
            {
                updatedCategory.Definition = request.Definition;
                await _repository.UpdateAsync(updatedCategory);
            }

            return Unit.Value;
        }
    }
}
