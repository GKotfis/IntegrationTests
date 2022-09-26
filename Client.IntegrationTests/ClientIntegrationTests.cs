using Microsoft.Extensions.DependencyInjection;

namespace Client.IntegrationTests;

public class ClientIntegrationTests
    : IClassFixture<ContainerFixture>
{
    private readonly ServiceProvider _serviceProvider;

    public ClientIntegrationTests(ContainerFixture fixture)
    {
        _serviceProvider = fixture.ServiceProvider;
    }

    [Fact]
    public async Task ConnectTo_Test()
    {
        var sut = _serviceProvider.GetService<IClientService>();
        await sut!.ConnectTo();
    }
}
