// ReSharper disable All

namespace WcfService;

[ServiceContract]
public interface IFrequenciaWS70633
{
    [OperationContract]
    int[] FrequenciaDiogoMedeiros(IEnumerable<int> array);
}

public class FrequenciaWS70633 : IFrequenciaWS70633
{
    public int[] FrequenciaDiogoMedeiros(IEnumerable<int> array)
    {
        var frequency = new int[10];
        foreach (var t in array) frequency[t]++;
        return frequency;
    }
}