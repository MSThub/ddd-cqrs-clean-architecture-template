using Microsoft.Extensions.Configuration;

namespace AT.Persistence.Infrastructures.PersistenceConfig;

public static class EFPersistence
{
    public static IPersistenceConfig BuildPersistenceConfig(
        IConfiguration appSetting,
        string configKey = "persistenceConfig")
    {
        var config = new PersistenceConfig();
        appSetting.Bind(configKey, config);

        return config;
    }
}
