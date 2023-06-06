namespace WCFService;

[ServiceContract]
public interface ICalculator
{
    [OperationContract]
    int Add(int a, int b);

    [OperationContract]
    int Subtract(int a, int b);
}

// ReSharper disable once ClassNeverInstantiated.Global
public class Calculator : ICalculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }
}