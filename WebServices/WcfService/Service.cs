namespace WcfService;

// ReSharper disable once ClassNeverInstantiated.Global
public class Service : IService
{
    public int Add(int a, int b)
    {
        return a + b;
    }


    public int Subtract(int a, int b)
    {
        return a - b;
    }


    public int Multiply(int a, int b)
    {
        return a * b;
    }


    public float Divide(int a, int b)
    {
        return (float)a / b;
    }


    public double CelsiusToFahrenheit(double celsius)
    {
        return 9.0 / 5.0 * celsius + 32;
    }


    public double FahrenheitToCelsius(double fahrenheit)
    {
        return 5.0 / 9.0 * (fahrenheit - 32);
    }


    public double CelsiusToKelvin(double celsius)
    {
        return celsius + 273.15;
    }


    public double KelvinToCelsius(double kelvin)
    {
        return kelvin - 273.15;
    }


    public int Max(IEnumerable<int> numbers)
    {
        return numbers.Max();
    }

    public int Min(IEnumerable<int> numbers)
    {
        return numbers.Min();
    }

    public int Sum(IEnumerable<int> numbers)
    {
        return numbers.Sum();
    }


    public int GetIndex(int[] numbers, int number)
    {
        return Array.IndexOf(numbers, number);
    }


    public string HelloWorld()
    {
        return "Hello World";
    }


    public string Reverse(string text)
    {
        var charArray = text.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }


    public double Average(IEnumerable<int> numbers)
    {
        return numbers.Average();
    }
}