using System.Net.Http.Json;

namespace StudentsApi;

public static class StudentApi
{
    private const string ApiUrl = "http://cd9c-193-136-157-72.ngrok.io/api/values";
    private static readonly HttpClient Client = new();

    public static async Task<Student[]> GetStudents()
    {
        var students = await Client.GetFromJsonAsync<Student[]>(ApiUrl);
        return students ?? Array.Empty<Student>();
    }

    public static async Task<Student?> GetStudent(int id)
    {
        var student = await Client.GetFromJsonAsync<Student>(ApiUrl + "/" + id);
        return student;
    }

    public static async Task<string> AddStudent(Student student)
    {
        var response = await Client.PostAsJsonAsync(ApiUrl, student);
        var content = await response.Content.ReadAsStringAsync();
        return content;
    }

    public static async Task<string> UpdateStudent(int id, Student student)
    {
        var response = await Client.PutAsJsonAsync(ApiUrl + "/" + id, student);
        var content = await response.Content.ReadAsStringAsync();
        return content;
    }

    public static async Task<string> DeleteStudent(int id)
    {
        var response = await Client.DeleteAsync(ApiUrl + "/" + id);
        var content = await response.Content.ReadAsStringAsync();
        return content;
    }
}