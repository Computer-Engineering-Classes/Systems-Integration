namespace WcfService;

[ServiceContract]
public interface IGradeCalculator
{
    [OperationContract]
    double CalculateFinalGrade(double f1, double f2, double qa);
}

// ReSharper disable once ClassNeverInstantiated.Global
public class GradeCalculator : IGradeCalculator
{
    public double CalculateFinalGrade(double f1, double f2, double qa)
    {
        return f1 * 0.4 + f2 * 0.4 + qa * 0.2;
    }
}