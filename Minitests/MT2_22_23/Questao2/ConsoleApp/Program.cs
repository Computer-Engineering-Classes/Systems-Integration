using ConsoleApp.FrequenciaWS70633;

var client = new FrequenciaWS70633Client();

// Random numbers between 0 and 9
var random = new Random();
var array = Enumerable.Range(0, 100).Select(_ => random.Next(0, 10)).ToArray();

var frequency = client.FrequenciaDiogoMedeiros(array);

Console.WriteLine($"Frequency of {string.Join(", ", array)}");
foreach (var (value, count) in frequency.Select((value, index) => (index, value)))
    Console.WriteLine($"{value} => {count}");