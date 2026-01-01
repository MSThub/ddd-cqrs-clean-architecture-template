using System.Data;
using AT.Application;
using AT.Application.Abstractions.Handlers;
using AT.Application.Abstractions.Persistence;
using AT.Persistence;
using AT.Persistence.Configurations;
using AT.Persistence.Infrastructures;
using Autofac;
using Microsoft.Data.SqlClient;

namespace AT.RestAPI.Configurations.Services;

public class AutofacBusinessModule : Module
{
    private readonly IPersistenceConfig _persistenceConfig;

    private const string ConnectionStringKey = "connectionString";

    public AutofacBusinessModule(IConfiguration configuration)
    {
        _persistenceConfig =
            EFPersistence.BuildPersistenceConfig(configuration);
    }

    protected override void Load(ContainerBuilder builder)
    {
        var persistentAssembly = typeof(IPersistentAssembly).Assembly;
        var applicationAssembly = typeof(IApplicationAssembly).Assembly;
        
        builder.RegisterAssemblyTypes(persistentAssembly)
            .AssignableTo<IRepository>()
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope();
        
        builder.RegisterAssemblyTypes(persistentAssembly)
            .AssignableTo<IQuery>()
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope();
        
        builder.RegisterAssemblyTypes(applicationAssembly)
            .AsClosedTypesOf(typeof(ICommandHandler<,>))
            .InstancePerLifetimeScope();

        builder.RegisterAssemblyTypes(applicationAssembly)
            .AsClosedTypesOf(typeof(IQueryHandler<,>))
            .InstancePerLifetimeScope();

        builder.RegisterType<EFDataContext>()
            .WithParameter(
                ConnectionStringKey, _persistenceConfig.ConnectionString)
            .AsSelf()
            .InstancePerLifetimeScope();

        builder.RegisterType<EFWriteDataContext>()
            .WithParameter(
                ConnectionStringKey, _persistenceConfig.ConnectionString)
            .AsSelf()
            .InstancePerLifetimeScope();

        builder.RegisterType<EFReadDataContext>()
            .WithParameter(
                ConnectionStringKey, _persistenceConfig.ReadConnectionString)
            .AsSelf()
            .InstancePerLifetimeScope();
        
        builder.RegisterType<SqlConnection>()
            .WithParameter(
                ConnectionStringKey,
                _persistenceConfig.ConnectionString)
            .As<IDbConnection>()
            .InstancePerLifetimeScope();

        base.Load(builder);
    }
}