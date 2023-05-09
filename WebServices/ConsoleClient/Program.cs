using ConsoleClient;
using ConsoleClient.Service;

await using var client = new ServiceClient();

while (true)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Hello World");
    Console.WriteLine("2. Arithmetics");
    Console.WriteLine("3. Temperature conversions");
    Console.WriteLine("4. Array/string operations");
    Console.WriteLine("6. Exit");
    Console.Write("Enter your choice: ");
    var choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.WriteLine(await client.HelloWorldAsync());
            break;
        case "2":
            await ClientOperations.Arithmetics(client);
            break;
        case "3":
            await ClientOperations.Temperature(client);
            break;
        case "4":
            await ClientOperations.Arrays(client);
            break;
        case "6":
            return;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
}