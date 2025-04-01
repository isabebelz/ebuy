using ebuy.Domain.Entities;
using ebuy.Domain.Interfaces.Repositories;

namespace ebuy.Domain.DomainServices
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> RegisterUserAsync(string name, string email, string password)
        {
            if (await _userRepository.GetByEmailAsync(email))
                throw new InvalidOperationException("User already exists.");

            var user = new User(name, email, password);
            _userRepository.Add(user);

            return user;
        }
    }
}
