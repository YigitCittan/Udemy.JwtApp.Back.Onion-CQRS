using MediatR;

using Udemy.JwtApp.Back.Onion.Application.Dto;
using Udemy.JwtApp.Back.Onion.Application.Interfaces;
using Udemy.JwtApp.Back.Onion.Domain;

namespace Udemy.JwtApp.Back.Onion.Application.Features.CQRS.Queries
{
    public class CheckUserRequestHandler : IRequestHandler<CheckUserQueryRequest, CheckUserResponseDto>
    {
        public readonly IRepository<AppUser> _userRepository;
        public readonly IRepository<AppRole> _roleRepository;

        public CheckUserRequestHandler(IRepository<AppUser> userRepository, IRepository<AppRole> roleRepository)
        {
            _userRepository = userRepository;
            _roleRepository = roleRepository;
        }

        public async Task<CheckUserResponseDto> Handle(CheckUserQueryRequest request, CancellationToken cancellationToken)
        {
            var dto = new CheckUserResponseDto();
            var user = await _userRepository.GetByFilterAsync(x => x.Username == request.UserName && x.Password == request.Password);
            
            if(user == null) 
            {
                dto.IsExist = false;
            }
            else
            {
                dto.UserName = user.Username;
                dto.Id = user.Id;
                dto.IsExist = true;
                var role = await _roleRepository.GetByFilterAsync(x => x.Id == user.AppRoleId);
                dto.Role = role?.Definition;
            }
            return dto;
        }
    }
}
