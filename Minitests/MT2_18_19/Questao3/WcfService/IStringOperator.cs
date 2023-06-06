namespace WcfService;

[ServiceContract]
public interface IStringOperator
{
    [OperationContract]
    int CountZeros(string str);
}

// ReSharper disable once ClassNeverInstantiated.Global
public class StringOperator : IStringOperator
{
    public int CountZeros(string str)
    {
        return str.Count(c => c == '0');
    }
}