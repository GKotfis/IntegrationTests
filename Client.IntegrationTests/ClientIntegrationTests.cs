using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;

namespace Client.IntegrationTests;

public class ClientIntegrationTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly IClientService _clientService;

    public ClientIntegrationTests(WebApplicationFactory<Program> factory)
    {
        _clientService = factory.Services.GetRequiredService<IClientService>();
    }
    
    [Fact]
    public async Task ConnectTo_Test()
    {
        await _clientService.ConnectTo();
    }
}