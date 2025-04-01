using ebuy.Domain.SeedWork;

namespace ebuy.Infra.Data.Repositories
{
    public class Repository<T> where T : IRepository<T>, IAggregateRoot
    {
    }
}
