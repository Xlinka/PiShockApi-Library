using static PiShockApi.Operations;
using System.Net.Http.Json;
using PiShockApi;

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
        try
        {
            var response = await client.PostAsJsonAsync("apioperate/", command);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        catch (HttpRequestException ex)
        {
            throw new PiShockApiException("An error occurred during the API request.", ex);
        }
        catch (Exception ex)
        {
            throw new PiShockApiException("An unexpected error occurred.", ex);
        }
    }

    public async Task<string> SendVibrateCommand(VibrateCommand command)
    {
        try
        {
            var response = await client.PostAsJsonAsync("apioperate/", command);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        catch (HttpRequestException ex)
        {
            throw new PiShockApiException("An error occurred during the API request.", ex);
        }
        catch (Exception ex)
        {
            throw new PiShockApiException("An unexpected error occurred.", ex);
        }
    }

    public async Task<string> SendBeepCommand(BeepCommand command)
    {
        try
        {
            var response = await client.PostAsJsonAsync("apioperate/", command);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        catch (HttpRequestException ex)
        {
            throw new PiShockApiException("An error occurred during the API request.", ex);
        }
        catch (Exception ex)
        {
            throw new PiShockApiException("An unexpected error occurred.", ex);
        }
    }
}