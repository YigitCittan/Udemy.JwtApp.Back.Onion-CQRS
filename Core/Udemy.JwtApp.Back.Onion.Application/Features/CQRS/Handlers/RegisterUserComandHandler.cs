using MediatR;
using Udemy.JwtApp.Back.Onion.Application.Enums;
using Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Comands;
using Udemy.JwtApp.Back.Onion.Application.Interfaces;
using Udemy.JwtApp.Back.Onion.Domain;


namespace Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Handlers
{
    public class RegisterUserComandHandler : IRequestHandler<RegisterUserComandRequest>
    {
        private readonly IRepository<AppUser> _repository;

        public RegisterUserComandHandler(IRepository<AppUser> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(RegisterUserComandRequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new AppUser
            {
                Password = request.Password,
                Username = request.UserName,
                AppRoleId = (int)RoleType.Member,
            });
            return Unit.Value;
        }
    }
}
