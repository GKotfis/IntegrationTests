namespace Client;

public class ClientService : IClientService
{
    private readonly HttpClient _httpClient;

    public ClientService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task ConnectTo()
    {
        var res = await _httpClient.GetAsync("https://baconipsum.com/api/?type=meat-and-filler");
        res.EnsureSuccessStatusCode();
    }
}