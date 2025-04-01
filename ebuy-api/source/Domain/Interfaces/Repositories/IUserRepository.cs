using ebuy.Domain.Entities;
using ebuy.Domain.SeedWork;

namespace ebuy.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User Add(User user);
        void Update(User user);
        Task<User?> GetByIdAsync(Guid id);
        Task<bool> GetByEmailAsync(string email);
    }
}
