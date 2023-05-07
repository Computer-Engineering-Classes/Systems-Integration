using System;
using System.Collections.Generic;
using System.IO;
using Ficha1.Models;

namespace Ficha1.ViewModels;

public class ListWindowViewModel
{
    private readonly string _studentsFile =
        $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\students.txt";

    public ListWindowViewModel()
    {
        using FileStream fs = new(_studentsFile, FileMode.Open);
        using StreamReader sr = new(fs);
        Students = new List<Student>();
        while (!sr.EndOfStream)
        {
            var line = sr.ReadLine();
            if (line == null) continue;
            var split = line.Split(',');
            Students.Add(new Student
            {
                Number = int.Parse(split[0]),
                Name = split[1],
                Email = split[2]
            });
        }
    }

    public List<Student> Students { get; }
}