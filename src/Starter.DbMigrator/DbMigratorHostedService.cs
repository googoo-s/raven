using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Castle.Core.Configuration;

using Serilog;

using Starter.Domain.Data;

using Volo.Abp;
using Volo.Abp.Data;

namespace Starter.DbMigrator;

public class DbMigratorHostedService : IHostedService
{
    private readonly IHostApplicationLifetime _hostApplicationLifetime;
    private readonly IConfiguration _configuration;

    public DbMigratorHostedService(IHostApplicationLifetime hostApplicationLifetime, IConfiguration configuration)
    {
        _hostApplicationLifetime = hostApplicationLifetime;
        _configuration = configuration;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        using var application = await AbpApplicationFactory.CreateAsync<StarterDbMigratorModule>(options =>
        {
            _ = options.Services.ReplaceConfiguration((Microsoft.Extensions.Configuration.IConfiguration)_configuration);
            options.UseAutofac();
            _ = options.Services.AddLogging(c => c.AddSerilog());
            options.AddDataMigrationEnvironment();
        });
        await application.InitializeAsync();

        await application
            .ServiceProvider
            .GetRequiredService<StarterDbMigrationService>()
            .MigrateAsync();

        await application.ShutdownAsync();

        _hostApplicationLifetime.StopApplication();
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}