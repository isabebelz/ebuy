namespace ebuy.Application.UseCases.Users.Command.CreateUser
{
    public class CreateUserResponseDTO
    {
        public Guid? Id { get; private set; }
        public string? Email { get; private set; }
    }
}
