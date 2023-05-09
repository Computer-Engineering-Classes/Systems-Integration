using ConsoleClient.Service;

namespace ConsoleClient;

public static class ClientOperations
{
    public static async Task Arithmetics(IService client)
    {
        Console.WriteLine("Arithmetic operations");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");
        Console.Write("Enter your choice: ");
        if (!int.TryParse(Console.ReadLine(), out var choice))
        {
            Console.WriteLine("Invalid choice");
            return;
        }

        Console.Write("Enter first number: ");
        var a = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write("Enter second number: ");
        var b = int.Parse(Console.ReadLine() ?? string.Empty);
        switch (choice)
        {
            case 1:
                Console.WriteLine("Add({0},{1}) = {2}", a, b, await client.AddAsync(a, b));
                break;
            case 2:
                Console.WriteLine("Subtract({0},{1}) = {2}", a, b, await client.SubtractAsync(a, b));
                break;
            case 3:
                Console.WriteLine("Multiply({0},{1}) = {2}", a, b, await client.MultiplyAsync(a, b));
                break;
            case 4:
                Console.WriteLine("Divide({0},{1}) = {2}", a, b, await client.DivideAsync(a, b));
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }

    public static async Task Temperature(IService client)
    {
        Console.WriteLine("Temperature conversions");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        Console.WriteLine("3. Celsius to Kelvin");
        Console.WriteLine("4. Kelvin to Celsius");
        Console.Write("Enter your choice: ");
        if (!int.TryParse(Console.ReadLine(), out var choice))
        {
            Console.WriteLine("Invalid choice");
            return;
        }

        Console.Write("Enter temperature: ");
        var temperature = double.Parse(Console.ReadLine() ?? string.Empty);
        switch (choice)
        {
            case 1:
                Console.WriteLine("CelsiusToFahrenheit({0}) = {1}", temperature,
                    await client.CelsiusToFahrenheitAsync(temperature));
                break;
            case 2:
                Console.WriteLine("FahrenheitToCelsius({0}) = {1}", temperature,
                    await client.FahrenheitToCelsiusAsync(temperature));
                break;
            case 3:
                Console.WriteLine("CelsiusToKelvin({0}) = {1}", temperature,
                    await client.CelsiusToKelvinAsync(temperature));
                break;
            case 4:
                Console.WriteLine("KelvinToCelsius({0}) = {1}", temperature,
                    await client.KelvinToCelsiusAsync(temperature));
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }

    public static async Task Arrays(IService client)
    {
        Console.WriteLine("Array operations");
        Console.WriteLine("1. GetIndex");
        Console.WriteLine("2. Max");
        Console.WriteLine("3. Min");
        Console.WriteLine("4. Sum");
        Console.WriteLine("5. Average");
        Console.WriteLine("6. Reverse string");
        Console.Write("Enter your choice: ");
        if (!int.TryParse(Console.ReadLine(), out var choice))
        {
            Console.WriteLine("Invalid choice");
            return;
        }

        if (choice == 6)
        {
            Console.Write("Enter string to reverse: ");
            var str = Console.ReadLine();
            Console.WriteLine("Reverse({0}) = {1}", str, await client.ReverseAsync(str));
            return;
        }

        Console.Write("Enter numbers separated by space: ");
        var numbers = Console.ReadLine()?
                          .Split(' ')
                          .Select(int.Parse)
                          .ToArray()
                      ?? Array.Empty<int>();
        switch (choice)
        {
            case 1:
                Console.Write("Enter number to search: ");
                var number = int.Parse(Console.ReadLine() ?? string.Empty);
                Console.WriteLine("GetIndex({0},{1}) = {2}", number, string.Join(",", numbers),
                    await client.GetIndexAsync(numbers, number));
                break;
            case 2:
                Console.WriteLine("Max({0}) = {1}", string.Join(",", numbers), await client.MaxAsync(numbers));
                break;
            case 3:
                Console.WriteLine("Min({0}) = {1}", string.Join(",", numbers), await client.MinAsync(numbers));
                break;
            case 4:
                Console.WriteLine("Sum({0}) = {1}", string.Join(",", numbers), await client.SumAsync(numbers));
                break;
            case 5:
                Console.WriteLine("Average({0}) = {1}", string.Join(",", numbers),
                    await client.AverageAsync(numbers));
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}