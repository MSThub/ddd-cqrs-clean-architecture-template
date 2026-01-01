namespace AT.Persistence.Infrastructures;

public interface IPersistenceConfig
{
    public string ConnectionString { get; }
    public string ReadConnectionString { get; }
}
