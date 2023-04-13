using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

const string exchangeName = "elevator-log";
channel.ExchangeDeclare(exchangeName, ExchangeType.Fanout);

// declare a server-named queue
var queueName = channel.QueueDeclare().QueueName;
channel.QueueBind(queueName, exchangeName, string.Empty);

Console.WriteLine(" [*] Waiting for logs.");

var consumer = new EventingBasicConsumer(channel);
consumer.Received += (_, ea) =>
{
    var body = ea.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);
    Console.WriteLine($" [x] {message}");
};
// Start listening for incoming messages
channel.BasicConsume(queueName, true, consumer);
Console.WriteLine("Listening for incoming messages...");
// Keep the program running, otherwise the consumer will be disposed
while (true) Thread.Sleep(1000);