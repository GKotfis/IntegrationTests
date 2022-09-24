using Microsoft.Extensions.DependencyInjection;

namespace Client;

public static class ClientExtension
{
    public static IServiceCollection AddClient(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddHttpClient<IClientService>();
        serviceCollection.AddScoped<IClientService, ClientService>();

        return serviceCollection;
    }
}