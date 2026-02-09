namespace Template.Persistence.Infrastructures.PersistenceConfig;

public class PersistenceConfig : IPersistenceConfig
{
    public string ConnectionString { get; set; } = default!;
    public string ReadConnectionString { get; set; } = default!;
}