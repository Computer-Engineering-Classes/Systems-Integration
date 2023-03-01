using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;

namespace Ficha1.ViewModels;

public class MainWindowViewModel : BaseViewModel
{
    private readonly string _studentsFile =
        $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\students.txt";

    private string _email = string.Empty;

    private string _name = string.Empty;

    private int _number;

    public int Number
    {
        get => _number;
        set
        {
            _number = value;
            OnPropertyChanged();
        }
    }

    public string Name
    {
        get => _name;
        set
        {
            _name = value;
            OnPropertyChanged();
        }
    }

    public string Email
    {
        get => _email;
        set
        {
            _email = value;
            OnPropertyChanged();
        }
    }

    public bool ValidateFields()
    {
        if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Email)) return false;

        return Number > 0 && new EmailAddressAttribute().IsValid(Email);
    }

    public void AddStudent()
    {
        // Write fields to file
        using var fs = new FileStream(_studentsFile, FileMode.Append);
        using var writer = new StreamWriter(fs);
        writer.WriteLine($"{Number},{Name},{Email}");
    }

    public void RemoveStudent()
    {
        // Read file
        var lines = File.ReadAllLines(_studentsFile);
        // Remove student
        var newLines = lines.Where(line => !line.StartsWith($"{Number},{Name},{Email}"));
        // Write file
        File.WriteAllLines(_studentsFile, newLines);
    }

    public void ClearFields()
    {
        Number = 0;
        Name = string.Empty;
        Email = string.Empty;
    }
}