namespace Template.Persistence.Infrastructures.PersistenceConfig;

public interface IPersistenceConfig
{
    public string ConnectionString { get; }
    public string ReadConnectionString { get; }
}
