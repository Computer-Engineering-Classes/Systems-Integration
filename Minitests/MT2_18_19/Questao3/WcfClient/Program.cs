using WcfClient.StringOperator;

var client = new StringOperatorClient();
var random = new Random();
var str = new string(
    Enumerable.Range(0, 100)
        .Select(_ => random.Next(0, 2).ToString()[0])
        .ToArray()
);
var count = await client.CountZerosAsync(str);
Console.WriteLine($"Count of zeros in {str} is {count}");