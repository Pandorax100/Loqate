using Loqate.Http;
using Loqate.Options;
using Loqate.QueryBuilders;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Loqate.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddLoqate(this IServiceCollection services)
    {
        services
            .AddHttpClient<ILoqateService, LoqateService>("LoqateClient", (provider, client) =>
            {
                var options = provider.GetRequiredService<IOptions<LoqateOptions>>().Value;

                client.BaseAddress = options.BaseAddress;
            })
            .AddHttpMessageHandler<AppendKeyHttpMessageHandler>();

        services.AddSingleton<QueryBuilderFactory>();
        services.AddTransient<AppendKeyHttpMessageHandler>();

        return services;
    }
}
