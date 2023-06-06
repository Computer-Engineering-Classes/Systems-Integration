// RabbitMQ Publisher
// ========================================

using System.Text;
using RabbitMQ.Client;

var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.ExchangeDeclare("logs", ExchangeType.Fanout);

while (true)
{
    Console.Write("Enter message: ");
    var message = Console.ReadLine() ?? string.Empty;
    var body = Encoding.UTF8.GetBytes(message);
    channel.BasicPublish("logs", string.Empty, null, body);
}