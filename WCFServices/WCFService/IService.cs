namespace WcfService;

[ServiceContract]
public interface IService
{
    [OperationContract]
    string GetData(int value);

    [OperationContract]
    CompositeType GetDataUsingDataContract(CompositeType composite);
}

// ReSharper disable once ClassNeverInstantiated.Global
public class Service : IService
{
    public string GetData(int value)
    {
        return $"You entered: {value}";
    }

    public CompositeType GetDataUsingDataContract(CompositeType composite)
    {
        if (composite == null) throw new ArgumentNullException(nameof(composite));

        if (composite.BoolValue) composite.StringValue += "Suffix";

        return composite;
    }
}

// Use a data contract as illustrated in the sample below to add composite types to service operations.
[DataContract]
public class CompositeType
{
    [DataMember] public bool BoolValue { get; set; } = true;

    [DataMember] public string StringValue { get; set; } = "Hello ";
}