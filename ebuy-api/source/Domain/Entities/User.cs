using ebuy.Domain.SeedWork;

namespace ebuy.Domain.Entities
{
    public class User : Entity
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public bool Active { get; private set; }
        public DateTime RegistrationDate { get; }

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
            Active = true;
            RegistrationDate = DateTime.UtcNow;
        }
    }
}
