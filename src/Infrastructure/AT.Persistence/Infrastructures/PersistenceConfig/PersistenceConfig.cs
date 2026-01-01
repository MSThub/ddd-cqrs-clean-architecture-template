namespace AT.Persistence.Infrastructures;

public class PersistenceConfig : IPersistenceConfig
{
    public string ConnectionString { get; set; } = default!;
    public string ReadConnectionString { get; set; } = default!;
}