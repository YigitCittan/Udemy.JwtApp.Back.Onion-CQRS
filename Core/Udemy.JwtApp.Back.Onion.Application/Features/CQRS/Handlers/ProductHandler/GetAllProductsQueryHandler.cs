using AutoMapper;
using MediatR;
using Udemy.JwtApp.Back.Onion.Application.Dto;
using Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Comands.ProductComands;
using Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Queries.ProductQueries;
using Udemy.JwtApp.Back.Onion.Application.Interfaces;
using Udemy.JwtApp.Back.Onion.Domain;


namespace Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Handlers.ProductHandler
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<ProductListDto>>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;
        public GetAllProductsQueryHandler(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ProductListDto>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetAllAsync();
            return _mapper.Map<List<ProductListDto>>(data);
        }
    }
}
