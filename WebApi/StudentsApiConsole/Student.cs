namespace StudentsApi;

public class Student
{
    public int Id { get; init; }

    public string? Name { get; init; }

    public string? Color { get; init; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Color: {Color}";
    }
}