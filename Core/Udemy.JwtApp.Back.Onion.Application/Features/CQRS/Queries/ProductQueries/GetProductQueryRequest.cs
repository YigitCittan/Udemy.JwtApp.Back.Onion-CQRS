using MediatR;
using Udemy.JwtApp.Back.Onion.Application.Dto;


namespace Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Queries.ProductQueries
{
    public class GetProductQueryRequest : IRequest<ProductListDto>
    {
        public int Id { get; set; }
        public GetProductQueryRequest(int id)
        {
            Id = id;
        }
    }

}
