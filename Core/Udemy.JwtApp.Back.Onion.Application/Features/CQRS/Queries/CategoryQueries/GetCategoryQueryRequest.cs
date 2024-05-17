using MediatR;
using Udemy.JwtApp.Back.Onion.Application.Dto;


namespace Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Queries.CategoryQueries
{
    public class GetCategoryQueryRequest : IRequest<CategoryListDto?>
    {
        public int Id { get; set; }
        public GetCategoryQueryRequest(int id)
        {
            Id = id;
        }
    }
}
