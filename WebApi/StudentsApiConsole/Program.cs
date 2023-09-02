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
    string response;
    string? name, color;
    Student? student;
    switch (choice)
    {
        case "1":
            var students = await StudentApi.GetStudents();
            Console.WriteLine(students);
            break;
        case "2":
            Console.Write("Enter id: ");
            if (!int.TryParse(Console.ReadLine(), out id)) continue;
            student = await StudentApi.GetStudent(id);
            if (student == null)
                Console.WriteLine("Student not found");
            else
                Console.WriteLine(student);
            break;
        case "3":
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter color: ");
            color = Console.ReadLine();
            student = new Student
            {
                Name = name,
                Color = color
            };
            response = await StudentApi.AddStudent(student);
            Console.WriteLine(response);
            break;
        case "4":
            Console.Write("Enter id: ");
            if (!int.TryParse(Console.ReadLine(), out id)) continue;
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter color: ");
            color = Console.ReadLine();
            student = new Student
            {
                Name = name,
                Color = color
            };
            response = await StudentApi.UpdateStudent(id, student);
            Console.WriteLine(response);
            break;
        case "5":
            Console.Write("Enter id: ");
            if (!int.TryParse(Console.ReadLine(), out id)) continue;
            response = await StudentApi.DeleteStudent(id);
            Console.WriteLine(response);
            break;
        case "6":
            return;
        default:
            Console.WriteLine("Invalid option. Try again.");
            break;
    }
}