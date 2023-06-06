using WcfClient.GradeCalculator;

var client = new GradeCalculatorClient();
Console.Write("Enter first final grade: ");
var f1 = double.Parse(Console.ReadLine() ?? string.Empty);
Console.Write("Enter second final grade: ");
var f2 = double.Parse(Console.ReadLine() ?? string.Empty);
Console.Write("Enter quiz average: ");
var qa = double.Parse(Console.ReadLine() ?? string.Empty);
var finalGrade = await client.CalculateFinalGradeAsync(f1, f2, qa);
Console.WriteLine($"Final grade: {finalGrade}");
var result = finalGrade switch
{
    >= 9.5 => "Congratulations, you passed the course!",
    >= 7.5 and < 9.5 => "You are eligible for the resit exam!",
    _ => "Sorry, you failed the course!"
};
Console.WriteLine(result);