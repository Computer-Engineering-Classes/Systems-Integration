using WCFClient.Calculator;

var client = new CalculatorClient();

Console.WriteLine("Add(2, 3) = {0}", await client.AddAsync(2, 3));
Console.WriteLine("Subtract(2, 3) = {0}", await client.SubtractAsync(2, 3));