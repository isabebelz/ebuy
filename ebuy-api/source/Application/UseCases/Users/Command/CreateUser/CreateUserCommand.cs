using MediatR;

namespace ebuy.Application.UseCases.Users.Command.CreateUser
{
    public class CreateUserCommand : IRequest<CreateUserResponseDTO>
    {
        public CreateUserDTO User { get; set; }

        public CreateUserCommand(CreateUserDTO user)
        {
            User = user;
        }
    }
}
