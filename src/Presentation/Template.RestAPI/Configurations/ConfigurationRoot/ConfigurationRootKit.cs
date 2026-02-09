namespace Template.RestAPI.Configurations.ConfigurationRoot;

public static class ConfigurationRootKit
{
    public static IConfigurationRoot GetConfiguration(
        params string[] settingFileNames)
    {
        var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

        var builder = new ConfigurationBuilder()
            .SetBasePath(baseDirectory)
            .AddEnvironmentVariables();

        foreach (var fileName in settingFileNames ?? Enumerable.Empty<string>())
        {
            builder.AddJsonFile(fileName, optional: true, reloadOnChange: true);
        }

        return builder.Build();
    }
}