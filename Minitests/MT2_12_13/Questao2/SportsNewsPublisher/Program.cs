using System.Text;
using RabbitMQ.Client;

var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.ExchangeDeclare("sports-news", ExchangeType.Topic);
const string topic = "sports-news.results";

while (true)
{
    Console.WriteLine("Enter a message:");
    var message = Console.ReadLine() ?? string.Empty;

    var body = Encoding.UTF8.GetBytes(message);

    channel.BasicPublish("sports-news", topic, null, body);
    Console.WriteLine("Sent {0}", message);
}