using AutoMapper;
using ebuy.Domain.DomainServices;
using ebuy.Domain.Entities;
using ebuy.Domain.SeedWork;
using MediatR;

namespace ebuy.Application.UseCases.Users.Command.CreateUser
{
    class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreateUserResponseDTO?>
    {
        private readonly UserService _userService;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public CreateUserCommandHandler(UserService userService,
                                        IMapper mapper,
                                        IUnitOfWork unitOfWork) 
        { 
            _userService = userService;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<CreateUserResponseDTO?> Handle(CreateUserCommand command, CancellationToken cancellationToken)
        {
            var user = await _userService.RegisterUserAsync(command.User.Name, command.User.Email, command.User.Password);

            if (user is null)
                return null;

            var response = _mapper.Map<CreateUserResponseDTO>(user);

            return response;
        }
    }
}
