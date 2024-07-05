using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using PiShockApi;

public class PiShockApiClient
{
    private readonly HttpClient client;
    private readonly ILogger<PiShockApiClient> logger;

    public PiShockApiClient(IHttpClientFactory httpClientFactory, ILogger<PiShockApiClient> logger, string baseApiUrl = "https://do.pishock.com/api/")
    {
        this.client = httpClientFactory.CreateClient();
        this.client.BaseAddress = new Uri(baseApiUrl);
        this.logger = logger;
    }

    public async Task<string> SendShockCommand(ShockCommand command)
    {
        return await SendCommandAsync(command);
    }

    public async Task<string> SendVibrateCommand(VibrateCommand command)
    {
        return await SendCommandAsync(command);
    }

    public async Task<string> SendBeepCommand(BeepCommand command)
    {
        return await SendCommandAsync(command);
    }

    private async Task<string> SendCommandAsync<T>(T command)
    {
        logger.LogInformation("Sending command: {@Command}", command);
        try
        {
            var response = await client.PostAsJsonAsync("apioperate/", command);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            logger.LogInformation("Command response: {Response}", result);
            return result;
        }
        catch (HttpRequestException ex)
        {
            logger.LogError(ex, "An error occurred during the API request.");
            throw new PiShockApiException("An error occurred during the API request.", ex);
        }
        catch (TaskCanceledException ex)
        {
            logger.LogError(ex, "The API request timed out.");
            throw new PiShockApiException("The API request timed out.", ex);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "An unexpected error occurred.");
            throw new PiShockApiException("An unexpected error occurred.", ex);
        }
    }
}

