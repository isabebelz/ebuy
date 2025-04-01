namespace ebuy.Application.UseCases.Users.Command.CreateUser
{
    public class CreateUserResponse
    {
        public Guid? Id { get; private set; }
        public string? Email { get; private set; }
    }
}
