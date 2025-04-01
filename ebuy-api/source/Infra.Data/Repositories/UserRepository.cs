using ebuy.Domain.Entities;
using ebuy.Domain.Interfaces.Repositories;
using ebuy.Domain.SeedWork;
using Microsoft.EntityFrameworkCore;

namespace ebuy.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly EbuyDbContext _context;
        public IUnitOfWork UnitOfWork => _context;

        public UserRepository(EbuyDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public User Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
        }

        public async Task<bool> GetByEmailAsync(string email)
        {
            var user = await _context.Users.Where(x => x.Email == email).FirstOrDefaultAsync();

            if (user is null)
                return false;

            return true;
        }

        public async Task<User?> GetByIdAsync(Guid id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user is null)
                return null;

            return user;
        }

        public void Update(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
        }
    }
}
