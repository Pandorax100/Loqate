using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Pandorax.Loqate;
using Pandorax.Loqate.Http;
using Pandorax.Loqate.Options;
using Pandorax.Loqate.QueryBuilders;

namespace Pandorax.Loqate.DependencyInjection;

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
