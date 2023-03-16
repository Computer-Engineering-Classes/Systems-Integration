using StudentsApi;

// REST API Client
while (true)
{
    Console.WriteLine("Student API Menu:");
    Console.WriteLine("\t1. Get all students");
    Console.WriteLine("\t2. Get student by id");
    Console.WriteLine("\t3. Add student");
    Console.WriteLine("\t4. Update student");
    Console.WriteLine("\t5. Delete student");
    Console.WriteLine("\t6. Exit");
    Console.Write("Enter your choice: ");
    var choice = Console.ReadLine();
    int id;
    string? name, color;
    switch (choice)
    {
        case "1":
            Console.WriteLine(StudentApi.GetStudents());
            break;
        case "2":
            Console.Write("Enter id: ");
            if (int.TryParse(Console.ReadLine(), out id) == false) continue;
            Console.WriteLine(StudentApi.GetStudent(id));
            break;
        case "3":
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter color: ");
            color = Console.ReadLine();
            var student = new Student
            {
                Name = name,
                Color = color
            };
            Console.WriteLine(StudentApi.AddStudent(student));
            break;
        case "4":
            Console.Write("Enter id: ");
            if (int.TryParse(Console.ReadLine(), out id) == false) continue;
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter color: ");
            color = Console.ReadLine();
            student = new Student
            {
                Name = name,
                Color = color
            };
            Console.WriteLine(StudentApi.UpdateStudent(id, student));
            break;
        case "5":
            Console.Write("Enter id: ");
            if (int.TryParse(Console.ReadLine(), out id) == false) continue;
            Console.WriteLine(StudentApi.DeleteStudent(id));
            break;
        case "6":
            return;
        default:
            Console.WriteLine("Invalid option. Try again.");
            break;
    }
}