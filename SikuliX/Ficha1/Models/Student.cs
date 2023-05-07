using System.ComponentModel.DataAnnotations;

namespace Ficha1.Models;

public class Student
{
    public int Number { get; set; }

    public string Name { get; set; } = string.Empty;

    [EmailAddress] public string Email { get; set; } = string.Empty;
}