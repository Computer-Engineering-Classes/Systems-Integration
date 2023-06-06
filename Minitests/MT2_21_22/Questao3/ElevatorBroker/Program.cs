using System.Text;
using RabbitMQ.Client;

var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

// declare a fan-out exchange
channel.ExchangeDeclare("elevator-logs", ExchangeType.Fanout);

while (true)
{
    Console.Write("Elevator: ");
    if (!int.TryParse(Console.ReadLine(), out var elevator)) continue;
    Console.WriteLine("Reason:");
    Console.WriteLine("1 - Technical failure");
    Console.WriteLine("2 - Maintenance");
    Console.WriteLine("3 - Short-circuit");
    Console.WriteLine("4 - Safety evaluation");
    Console.Write("Option: ");
    if (!int.TryParse(Console.ReadLine(), out var option)) continue;
    var reason = option switch
    {
        1 => "Technical failure",
        2 => "Maintenance",
        3 => "Short-circuit",
        4 => "Safety evaluation",
        _ => "Other"
    };
    var message = $"Elevator {elevator} - {reason}";
    var body = Encoding.UTF8.GetBytes(message);
    channel.BasicPublish("elevator-logs",
        string.Empty,
        null,
        body);
}