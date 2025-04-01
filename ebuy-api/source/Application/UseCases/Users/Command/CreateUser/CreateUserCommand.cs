using MediatR;

namespace ebuy.Application.UseCases.Users.Command.CreateUser
{
    public class CreateUserCommand : IRequest<CreateUserResponse>
    {
        public CreateUserRequest User { get; set; }

        public CreateUserCommand(CreateUserRequest user)
        {
            User = user;
        }
    }
}
