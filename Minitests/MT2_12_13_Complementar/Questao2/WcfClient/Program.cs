using WcfClient.RandomGenerator;

var client = new RandomGeneratorClient();
var prevNumber = await client.GetRandomNumberAsync(1, 100);
while (true)
{
    Console.WriteLine("Press any key to get a random number");
    Console.ReadKey();
    var number = await client.GetRandomNumberAsync(1, 100);
    Console.WriteLine($"Random number: {number}");
    if (number == prevNumber)
    {
        Console.WriteLine("BAD ALGORITHM!");
        break;
    }
    prevNumber = number;
}