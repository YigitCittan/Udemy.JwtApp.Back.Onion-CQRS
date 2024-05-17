using AutoMapper;
using MediatR;
using Udemy.JwtApp.Back.Onion.Application.Dto;
using Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Comands.CategoryComands;
using Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Queries.CategoryQueries;
using Udemy.JwtApp.Back.Onion.Application.Interfaces;
using Udemy.JwtApp.Back.Onion.Domain;


namespace Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Handlers.CategoryHandler
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQueryRequest, CategoryListDto?>
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;
        public GetCategoryQueryHandler(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CategoryListDto> Handle(GetCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetByFilterAsync(x => x.Id == request.Id);
            return _mapper.Map<CategoryListDto>(result);
        }
    }
}
