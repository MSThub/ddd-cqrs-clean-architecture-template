using Template.RestAPI.Configurations.ConfigurationRoot;
using Template.RestAPI.Configurations.Services;

var config = ConfigurationRootKit
    .GetConfiguration("appsettings.json");

var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    EnvironmentName = config.GetValue(
        "environment", defaultValue: "Development"),
});

var services = builder.Services;

services
    .AddRouting()
    .AddHttpContextAccessor()
    .AddEndpointsApiExplorer()
    .AddSwaggerGen()
    .AddControllers();

builder.Host.SetupAutofac(config);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();

app.MapControllers();

app.Run();