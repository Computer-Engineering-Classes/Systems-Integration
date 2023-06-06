using System.Text;
using RabbitMQ.Client;

var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.ExchangeDeclare("sensor-logs", ExchangeType.Fanout);

while (true)
{
    Console.WriteLine("Sensor type:");
    Console.WriteLine("1 - Rotation speed (revolutions per minute)");
    Console.WriteLine("2 - Fuel consumption (liters per kilometer)");
    Console.WriteLine("Option:");
    if (!int.TryParse(Console.ReadLine(), out var option)) continue;
    Console.WriteLine("Value:");
    if (!double.TryParse(Console.ReadLine(), out var value)) continue;
    var message = option switch
    {
        1 => $"rpm:{value}",
        2 => $"l/km:{value}",
        _ => null
    };
    if (message == null) continue;
    var body = Encoding.UTF8.GetBytes(message);
    channel.BasicPublish("sensor-logs",
        string.Empty,
        null,
        body);
    Console.WriteLine($"Sent: {message}");
}