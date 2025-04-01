using System.Text.RegularExpressions;
using ebuy.Domain.SeedWork;

namespace ebuy.Domain.Entities
{
    public class User : Entity, IAggregateRoot
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public bool Active { get; private set; }
        public DateTime RegistrationDate { get; }

        public User(string name, string email, string password)
        {
            SetName(name);
            Email = email;
            SetPassword(password);
            Active = true;
            RegistrationDate = DateTime.UtcNow;
        }

        public void SetPassword(string password)
        {
            if (!IsStrongPassword(password))
                throw new ArgumentException("Password is not strong enough.");

            Password = password;
        }

        private bool IsStrongPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
                return false;

            var regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=!]).{8,}$");
            return regex.IsMatch(password);
        }

        public void SetName(string name)
        {
            if (!IsInvalidName(name))
                throw new ArgumentNullException("Invalid name. It must have at least 3 non-space characters.");

            Name = name.Trim();
        }

        private bool IsInvalidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            string trimmedName = name.Trim();
            return trimmedName.Length >= 3;
        }

        public void Deactivate()
        {
            if (!Active)
                throw new InvalidOperationException("User is already inactive.");

            Active = false;
        }
    }
}
