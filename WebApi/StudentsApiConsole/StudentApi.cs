using System.Net.Http.Json;

namespace StudentsApi;

public static class StudentApi
{
    private static readonly HttpClient Client = new();
    private const string ApiUrl = "http://cd9c-193-136-157-72.ngrok.io/api/values";

    public static string GetStudents()
    {
        var response = Client.GetAsync(ApiUrl).Result;
        var content = response.Content.ReadAsStringAsync().Result;
        return content;
    }
    
    public static string GetStudent(int id)
    {
        var response = Client.GetAsync(ApiUrl + "/" + id).Result;
        var content = response.Content.ReadAsStringAsync().Result;
        return content;
    }
    
    public static string AddStudent(Student student)
    {
        var response = Client.PostAsJsonAsync(ApiUrl, student).Result;
        var content = response.Content.ReadAsStringAsync().Result;
        return content;
    }
    
    public static string UpdateStudent(int id, Student student)
    {
        var response = Client.PutAsJsonAsync(ApiUrl + "/" + id, student).Result;
        var content = response.Content.ReadAsStringAsync().Result;
        return content;
    }
    
    public static string DeleteStudent(int id)
    {
        var response = Client.DeleteAsync(ApiUrl + "/" + id).Result;
        var content = response.Content.ReadAsStringAsync().Result;
        return content;
    }
}