using System.Text.Json;
using System.Text.Json.Nodes;

namespace CountriesApiConsole;

public static class CountriesApi
{
    private const string ApiUrl = "https://restcountries.com/v3.1";
    private static readonly HttpClient Client = new();

    public static async Task<JsonArray?> GetCountries()
    {
        var response = await Client.GetAsync(ApiUrl + "/all");
        var content = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<JsonArray>(content);
    }

    public static async Task<JsonNode?> GetCountry(string name)
    {
        var response = await Client.GetAsync(ApiUrl + "/name/" + name);
        var content = await response.Content.ReadAsStringAsync();
        return content.Contains("\"status\":404") ? null : JsonSerializer.Deserialize<JsonArray>(content)?[0];
    }
}