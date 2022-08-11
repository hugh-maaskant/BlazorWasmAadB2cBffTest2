namespace BlazorWasmAadB2cBffTest2.Client.Services;

public interface IAntiforgeryHttpClientFactory
{
    Task<HttpClient> CreateClientAsync(string clientName = "authorizedClient");
}
