using MediatR;
using Udemy.JwtApp.Back.Onion.Application.Dto;


namespace Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Queries
{
    public class CheckUserQueryRequest : IRequest<CheckUserResponseDto>
    {
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
