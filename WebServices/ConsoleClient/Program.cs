using ConsoleClient;

var clientOps = new ClientOperations();

while (true)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Hello World");
    Console.WriteLine("2. Arithmetics");
    Console.WriteLine("3. Temperature conversions");
    Console.WriteLine("4. Array/string operations");
    Console.WriteLine("5. Exit");
    Console.Write("Enter your choice: ");
    if (!int.TryParse(Console.ReadLine(), out var choice))
    {
        Console.WriteLine("Invalid choice");
        continue;
    }

    switch (choice)
    {
        case 1:
            await clientOps.HelloWorld();
            break;
        case 2:
            await clientOps.Arithmetics();
            break;
        case 3:
            await clientOps.Temperature();
            break;
        case 4:
            await clientOps.Arrays();
            break;
        case 5:
            return;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
}