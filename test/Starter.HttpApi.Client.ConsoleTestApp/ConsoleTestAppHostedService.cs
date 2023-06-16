using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;

namespace Starter.HttpApi.Client;

public class ConsoleTestAppHostedService : IHostedService
{
    private readonly IConfiguration _configuration;

    public ConsoleTestAppHostedService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        using var application = await AbpApplicationFactory.CreateAsync<StarterConsoleApiClientModule>(options =>
        {
            _ = options.Services.ReplaceConfiguration(_configuration);
            options.UseAutofac();
        });
        await application.InitializeAsync();

        var demo = application.ServiceProvider.GetRequiredService<ClientDemoService>();
        await demo.RunAsync();

        await application.ShutdownAsync();
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
