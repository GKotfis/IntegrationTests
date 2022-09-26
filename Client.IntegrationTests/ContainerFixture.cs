using Microsoft.Extensions.DependencyInjection;

namespace Client.IntegrationTests;

public class ContainerFixture
{
    public ContainerFixture()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddClient();

        ServiceProvider = serviceCollection.BuildServiceProvider();
    }

    public ServiceProvider ServiceProvider { get; }
}
