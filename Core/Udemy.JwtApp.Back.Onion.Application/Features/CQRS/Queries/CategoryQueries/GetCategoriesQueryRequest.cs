using MediatR;
using Udemy.JwtApp.Back.Onion.Application.Dto;


namespace Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Queries.CategoryQueries
{
    public class GetCategoriesQueryRequest : IRequest<List<CategoryListDto>>
    {
    }
}
