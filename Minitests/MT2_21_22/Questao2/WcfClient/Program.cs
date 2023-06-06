using WcfClient.Service;

var client = new ServiceClient();

Console.WriteLine("Enter hours worked: ");
var hours = int.Parse(Console.ReadLine() ?? string.Empty);

Console.WriteLine("Enter hourly rate: ");
var rate = decimal.Parse(Console.ReadLine() ?? string.Empty);

var salary = await client.CalculateSalaryAsync(hours, rate);
Console.WriteLine($"Salary: {salary:C}");

