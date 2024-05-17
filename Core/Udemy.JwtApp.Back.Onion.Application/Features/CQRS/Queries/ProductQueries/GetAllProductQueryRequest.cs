using MediatR;
using Udemy.JwtApp.Back.Onion.Application.Dto;


namespace Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Queries.ProductQueries
{
    public class GetAllProductQueryRequest : IRequest<List<ProductListDto>>
    {
    }
}
