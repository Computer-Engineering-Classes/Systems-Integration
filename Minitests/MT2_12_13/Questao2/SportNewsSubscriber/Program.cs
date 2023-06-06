using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.ExchangeDeclare("sports-news", ExchangeType.Topic);
const string topic = "sports-news.results";

var queueName = channel.QueueDeclare().QueueName;
channel.QueueBind(queueName, "sports-news", topic);

var consumer = new EventingBasicConsumer(channel);
consumer.Received += (_, args) =>
{
    var message = Encoding.UTF8.GetString(args.Body.ToArray());
    Console.WriteLine("Received {0}", message);
};
channel.BasicConsume(queueName, true, consumer);

Console.WriteLine("Waiting for messages...");
Console.ReadKey();