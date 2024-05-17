using MediatR;

namespace Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Comands
{
    public class RegisterUserComandRequest : IRequest
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}
