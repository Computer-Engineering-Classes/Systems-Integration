// RabbitMQ Subscriber
// ========================================

using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.ExchangeDeclare("logs", ExchangeType.Fanout);

var queueName = channel.QueueDeclare().QueueName;
channel.QueueBind(queueName, "logs", string.Empty);

var consumer = new EventingBasicConsumer(channel);
consumer.Received += (_, args) =>
{
    var body = args.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);
    Console.WriteLine($"Received: {message}");
};

channel.BasicConsume(queueName, true, consumer);

Console.WriteLine("Press any key to exit");
Console.ReadKey();