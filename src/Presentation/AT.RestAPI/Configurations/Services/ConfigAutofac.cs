using Autofac;
using Autofac.Extensions.DependencyInjection;

namespace AT.RestAPI.Configurations.Services;

public static class ConfigAutofac
{
   public static ConfigureHostBuilder SetupAutofac(
      this ConfigureHostBuilder builder,
      IConfiguration configuration)
   {
      builder.UseServiceProviderFactory(new AutofacServiceProviderFactory());
      builder.ConfigureContainer<ContainerBuilder>(b =>
         b.RegisterModule(new AutofacBusinessModule(configuration))
      );
      return builder;
   }
}