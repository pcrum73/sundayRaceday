public class AzureCosmosDb
{
    private readonly HttpClient _httpClient;

    public AzureCosmosDb(HttpClient httpClient)
    {
        _httpClient = httpClient;

        _httpClient.BaseAddress = new Uri("pcrum73.mongo.cosmos.azure.com:10255");

    }
}