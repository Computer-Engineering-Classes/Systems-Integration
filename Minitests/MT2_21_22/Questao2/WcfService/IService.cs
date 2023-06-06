namespace WcfService;

// ReSharper disable once ClassNeverInstantiated.Global
public class Service : IService
{
    public decimal CalculateSalary(int hours, decimal rate)
    {
        if (hours <= 40) return hours * rate;
        return 40 * rate + (hours - 40) * rate * 2.0M;
    }
}

[ServiceContract]
public interface IService
{
    [OperationContract]
    decimal CalculateSalary(int hours, decimal rate);
}