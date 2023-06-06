namespace TaxCalculator;

[ServiceContract]
public interface ITaxCalculator
{
    [OperationContract]
    decimal AddTax(decimal value);
}

// ReSharper disable once ClassNeverInstantiated.Global
public class TaxCalculator : ITaxCalculator
{
    public decimal AddTax(decimal value)
    {
        return value * 1.235m;
    }
}