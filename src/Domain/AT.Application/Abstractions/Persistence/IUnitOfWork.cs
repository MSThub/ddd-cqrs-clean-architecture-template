namespace AT.Application.Abstractions.Persistence;

public interface IUnitOfWork : IRepository
{
    Task SaveChangesAsync();
}