using ConsoleClient.Service;

namespace ConsoleClient;

public class ClientOperations
{
    private readonly ServiceClient _client = new();

    public async Task HelloWorld()
    {
        Console.WriteLine(await _client.HelloWorldAsync());
    }

    public async Task Arithmetics()
    {
        Console.WriteLine("Arithmetic operations");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");
        Console.Write("Enter your choice: ");
        var choice = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write("Enter first number: ");
        var a = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write("Enter second number: ");
        var b = int.Parse(Console.ReadLine() ?? string.Empty);
        var result = choice switch
        {
            1 => $"Add({a},{b}) = {await _client.AddAsync(a, b)}",
            2 => $"Subtract({a},{b}) = {await _client.SubtractAsync(a, b)}",
            3 => $"Multiply({a},{b}) = {await _client.MultiplyAsync(a, b)}",
            4 => $"Divide({a},{b}) = {await _client.DivideAsync(a, b)}",
            _ => "Invalid choice"
        };
        Console.WriteLine(result);
    }

    public async Task Temperature()
    {
        Console.WriteLine("Temperature conversions");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        Console.WriteLine("3. Celsius to Kelvin");
        Console.WriteLine("4. Kelvin to Celsius");
        Console.Write("Enter your choice: ");
        var choice = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write("Enter temperature: ");
        var temperature = double.Parse(Console.ReadLine() ?? string.Empty);
        var result = choice switch
        {
            1 => $"CelsiusToFahrenheit({temperature}) = {await _client.CelsiusToFahrenheitAsync(temperature)}",
            2 => $"FahrenheitToCelsius({temperature}) = {await _client.FahrenheitToCelsiusAsync(temperature)}",
            3 => $"CelsiusToKelvin({temperature}) = {await _client.CelsiusToKelvinAsync(temperature)}",
            4 => $"KelvinToCelsius({temperature}) = {await _client.KelvinToCelsiusAsync(temperature)}",
            _ => "Invalid choice"
        };
        Console.WriteLine(result);
    }

    public async Task Arrays()
    {
        Console.WriteLine("Array operations");
        Console.WriteLine("1. GetIndex");
        Console.WriteLine("2. Max");
        Console.WriteLine("3. Min");
        Console.WriteLine("4. Sum");
        Console.WriteLine("5. Average");
        Console.WriteLine("6. Reverse string");
        Console.Write("Enter your choice: ");
        var choice = int.Parse(Console.ReadLine() ?? string.Empty);
        if (choice == 6)
        {
            Console.Write("Enter string to reverse: ");
            var str = Console.ReadLine();
            Console.WriteLine("Reverse({0}) = {1}", str, await _client.ReverseAsync(str));
            return;
        }

        Console.Write("Enter numbers separated by space: ");
        var numbers = Console.ReadLine()?
            .Split(' ')
            .Select(int.Parse)
            .ToArray() ?? Array.Empty<int>();
        var numbersStr = string.Join(",", numbers);
        if (choice == 1)
        {
            Console.Write("Enter number to search: ");
            var number = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("GetIndex({0},{1}) = {2}", number, numbersStr,
                await _client.GetIndexAsync(numbers, number));
            return;
        }

        var result = choice switch
        {
            2 => $"Max({numbersStr}) = {await _client.MaxAsync(numbers)}",
            3 => $"Min({numbersStr}) = {await _client.MinAsync(numbers)}",
            4 => $"Sum({numbersStr}) = {await _client.SumAsync(numbers)}",
            5 => $"Average({numbersStr}) = {await _client.AverageAsync(numbers)}",
            _ => "Invalid choice"
        };
        Console.WriteLine(result);
    }
}