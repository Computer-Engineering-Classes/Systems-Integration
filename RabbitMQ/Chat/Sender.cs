using System.Text;
using RabbitMQ.Client;

namespace Chat;

public static class Sender
{
    public static void SendMessage()
    {
        var factory = new ConnectionFactory { HostName = "localhost" };
        using var connection = factory.CreateConnection();
        using var channel = connection.CreateModel();

        channel.ExchangeDeclare("logs", ExchangeType.Fanout);

        while (true)
        {
            var message = GetMessage();
            if (string.IsNullOrEmpty(message)) break;
            var body = Encoding.UTF8.GetBytes(message);
            channel.BasicPublish("logs",
                string.Empty,
                null,
                body);
            Console.WriteLine($" [x] Sent {message}");
        }
    }

    private static string GetMessage()
    {
        Console.WriteLine("Enter a message to send:");
        return Console.ReadLine() ?? string.Empty;
    }
}