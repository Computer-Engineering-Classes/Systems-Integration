using System.Text;
using RabbitMQ.Client;

var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.ExchangeDeclare("logs", ExchangeType.Fanout);

var message = GetMessage(args);
var body = Encoding.UTF8.GetBytes(message);
channel.BasicPublish("logs",
    string.Empty,
    null,
    body);
Console.WriteLine($" [x] Sent {message}");

Console.WriteLine(" Press [enter] to exit.");
Console.ReadLine();

static string GetMessage(string[] args)
{
    return args.Length > 0 ? string.Join(" ", args) : "info: Hello World!";
}