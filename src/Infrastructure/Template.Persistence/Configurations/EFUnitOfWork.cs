using Template.Contracts.Persistence;

namespace Template.Persistence.Configurations;

public class EFUnitOfWork(
    EFWriteDataContext dataContext)
    : IUnitOfWork
{
    public Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}