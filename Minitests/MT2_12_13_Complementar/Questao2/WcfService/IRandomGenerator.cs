using System.Security.Cryptography;

namespace WcfService;

[ServiceContract]
public interface IRandomGenerator
{
    [OperationContract]
    int GetRandomNumber(int min, int max);
}

// ReSharper disable once ClassNeverInstantiated.Global
public class RandomGenerator : IRandomGenerator
{
    public int GetRandomNumber(int min, int max)
    {
        return RandomNumberGenerator.GetInt32(min, max);
    }
}