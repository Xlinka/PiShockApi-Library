using static PiShockApi.Operations;
using System.Net.Http.Json;

public class PiShockApiClient
{
    private readonly HttpClient client;

    public PiShockApiClient()
    {
        client = new HttpClient();
        client.BaseAddress = new Uri("https://do.pishock.com/api/");
    }

    public async Task<string> SendShockCommand(ShockCommand command)
    {
        var response = await client.PostAsJsonAsync("apioperate/", command);
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> SendVibrateCommand(VibrateCommand command)
    {
        var response = await client.PostAsJsonAsync("apioperate/", command);
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> SendBeepCommand(BeepCommand command)
    {
        var response = await client.PostAsJsonAsync("apioperate/", command);
        return await response.Content.ReadAsStringAsync();
    }
}
