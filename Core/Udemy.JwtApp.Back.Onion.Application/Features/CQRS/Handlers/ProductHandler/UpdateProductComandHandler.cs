using MediatR;
using Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Comands.ProductComands;
using Udemy.JwtApp.Back.Onion.Application.Interfaces;
using Udemy.JwtApp.Back.Onion.Domain;


namespace Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Handlers.ProductHandler
{
    public class UpdateProductComandHandler : IRequestHandler<UpdateProductComandRequest>
    {
        private readonly IRepository<Product> _repository;

        public UpdateProductComandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateProductComandRequest request, CancellationToken cancellationToken)
        {
            var updatedProduct = await _repository.GetByIdAsync(request.Id);
            if (updatedProduct != null)
            {
                updatedProduct.CategoryId = request.CategoryId;
                updatedProduct.Price = request.Price;
                updatedProduct.Stock = request.Stock;
                updatedProduct.Name = request.Name;
                await _repository.UpdateAsync(updatedProduct);
            }

            return Unit.Value;
        }
    }
}
