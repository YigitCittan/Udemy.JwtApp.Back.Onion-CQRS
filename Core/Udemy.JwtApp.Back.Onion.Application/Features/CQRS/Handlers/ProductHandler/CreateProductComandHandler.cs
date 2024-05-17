using MediatR;
using Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Comands.ProductComands;
using Udemy.JwtApp.Back.Onion.Application.Interfaces;
using Udemy.JwtApp.Back.Onion.Domain;


namespace Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Handlers.ProductHandler
{
    public class CreateProductComandHandler : IRequestHandler<CreateProductComandRequest>
    {
        private readonly IRepository<Product> _repository;

        public CreateProductComandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateProductComandRequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Product
            {
                CategoryId = request.CategoryId,
                Name = request.Name,
                Price = request.Price,
                Stock = request.Stock,
            });
            return Unit.Value;
        }
    }
}
