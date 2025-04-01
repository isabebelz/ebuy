using ebuy.Domain.Entities;
using ebuy.Domain.SeedWork;

namespace ebuy.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task AddAsync(User user);
        void UpdateAsync(User user);
        Task<User> GetByIdAsync(Guid id);
        Task<bool> GetByEmailAsync(string email);
    }
}
