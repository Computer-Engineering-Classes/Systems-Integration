using System.Text.Json;
using System.Text.Json.Nodes;

namespace CountriesApiConsole;

public static class CountriesApi
{
    private static readonly HttpClient Client = new();
    private const string ApiUrl = "https://restcountries.com/v3.1";
    
    public static JsonArray? GetCountries()
    {
        var response = Client.GetAsync(ApiUrl + "/all").Result;
        var content = response.Content.ReadAsStringAsync().Result;
        return JsonSerializer.Deserialize<JsonArray>(content);
    }
    
    public static JsonNode? GetCountry(string? name)
    {
        var response = Client.GetAsync(ApiUrl + "/name/" + name).Result;
        var content = response.Content.ReadAsStringAsync().Result;
        return content.Contains("\"status\":404") ? null : JsonSerializer.Deserialize<JsonArray>(content)?[0];
    }
}