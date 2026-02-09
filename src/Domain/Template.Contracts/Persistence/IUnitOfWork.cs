namespace Template.Contracts.Persistence;

public interface IUnitOfWork : IRepository
{
    Task SaveChangesAsync();
}