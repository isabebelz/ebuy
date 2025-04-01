using AutoMapper;
using ebuy.Domain.DomainServices;
using MediatR;

namespace ebuy.Application.UseCases.Users.Command.CreateUser
{
    class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreateUserResponse?>
    {
        private readonly UserService _userService;
        private readonly IMapper _mapper;
        public CreateUserCommandHandler(UserService userService,
                                        IMapper mapper) 
        { 
            _userService = userService;
            _mapper = mapper;
        }

        public async Task<CreateUserResponse?> Handle(CreateUserCommand command, CancellationToken cancellationToken)
        {
            var user = await _userService.RegisterUserAsync(command.User.Name, command.User.Email, command.User.Password);

            if (user is null)
                return null;

            var response = _mapper.Map<CreateUserResponse>(user);

            return response;
        }
    }
}
