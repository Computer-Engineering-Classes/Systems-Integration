using System.Diagnostics.CodeAnalysis;

namespace WcfService;

[ServiceContract]
[SuppressMessage("ReSharper", "UnusedMember.Global")]
public interface IService
{
    [OperationContract]
    int Add(int a, int b);

    [OperationContract]
    int Subtract(int a, int b);

    [OperationContract]
    int Multiply(int a, int b);

    [OperationContract]
    float Divide(int a, int b);

    [OperationContract]
    double CelsiusToFahrenheit(double celsius);

    [OperationContract]
    double FahrenheitToCelsius(double fahrenheit);

    [OperationContract]
    double CelsiusToKelvin(double celsius);

    [OperationContract]
    double KelvinToCelsius(double kelvin);

    [OperationContract]
    int Max(IEnumerable<int> numbers);

    [OperationContract]
    int Min(IEnumerable<int> numbers);

    [OperationContract]
    int Sum(IEnumerable<int> numbers);

    [OperationContract]
    double Average(IEnumerable<int> numbers);

    [OperationContract]
    int GetIndex(int[] numbers, int number);

    [OperationContract]
    string HelloWorld();

    [OperationContract]
    string Reverse(string text);
}