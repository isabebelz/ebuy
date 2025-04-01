namespace ebuy.Application.UseCases.Users.Command.CreateUser
{
    public class CreateUserRequest
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
