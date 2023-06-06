namespace CurrencyConverter;

[ServiceContract]
public interface ICurrencyConverter
{
    [OperationContract]
    decimal EscudoToEuro(decimal value);
}

// ReSharper disable once ClassNeverInstantiated.Global
public class CurrencyConverter : ICurrencyConverter
{
    public decimal EscudoToEuro(decimal value)
    {
        return value / 200.482m;
    }
}