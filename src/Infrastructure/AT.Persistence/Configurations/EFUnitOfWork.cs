

using AT.Application.Abstractions.Persistence;

namespace AT.Persistence.Configurations;

public class EFUnitOfWork(
    EFWriteDataContext dataContext)
    : IUnitOfWork
{
    public Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}