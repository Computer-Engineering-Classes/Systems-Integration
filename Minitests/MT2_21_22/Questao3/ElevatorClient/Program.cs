using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

// declare a fan-out exchange
channel.ExchangeDeclare("elevator-logs", ExchangeType.Fanout);

// bind the queue to the exchange
var queueName = channel.QueueDeclare().QueueName;
channel.QueueBind(queueName, "elevator-logs", string.Empty);

// start consuming messages
var consumer = new EventingBasicConsumer(channel);
consumer.Received += (_, ea) =>
{
    var message = Encoding.UTF8.GetString(ea.Body.ToArray());
    Console.WriteLine(message);
};

channel.BasicConsume(queueName, true, consumer);

while(true)
{
    Console.WriteLine("Press (Enter) to exit...");
    if (Console.ReadKey().Key == ConsoleKey.Enter) break;
}