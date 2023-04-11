using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace Chat;

public static class Receiver
{
    public static void ReceiveMessage()
    {
        var factory = new ConnectionFactory { HostName = "localhost" };
        using var connection = factory.CreateConnection();
        using var channel = connection.CreateModel();

        channel.ExchangeDeclare("logs", ExchangeType.Fanout);

        // declare a server-named queue
        var queueName = channel.QueueDeclare().QueueName;
        channel.QueueBind(queueName,
            "logs",
            string.Empty);
        
        var consumer = new EventingBasicConsumer(channel);
        consumer.Received += (_, ea) =>
        {
            var body = ea.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);
            Console.WriteLine($" [x] {message}");
        };

        while (true)
        {
            channel.BasicConsume("logs",
                true,
                consumer);
            Thread.Sleep(100);
        }
    }
}