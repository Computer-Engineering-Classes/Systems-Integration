using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace Chat;

public class ChatHandler
{
    private const string ExchangeName = "chat";
    private readonly IModel _channel;
    private readonly EventingBasicConsumer _consumer;
    private readonly string _queueName;
    private string _username = "anonymous";

    public ChatHandler(IModel channel)
    {
        _channel = channel;
        _channel.ExchangeDeclare(ExchangeName, ExchangeType.Fanout);
        _queueName = _channel.QueueDeclare().QueueName;
        _channel.QueueBind(_queueName, ExchangeName, string.Empty);
        _consumer = new EventingBasicConsumer(_channel);
    }

    public void StartListening()
    {
        _consumer.Received += (_, ea) =>
        {
            var body = ea.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);
            Console.WriteLine($"\n{message}");
        };
        _channel.BasicConsume(_queueName, true, _consumer);
    }

    public void SendMessage(string message)
    {
        message = $"{_username}: {message}";
        var body = Encoding.UTF8.GetBytes(message);
        _channel.BasicPublish(ExchangeName, string.Empty, null, body);
    }

    public void SendJoinMessage(string username)
    {
        if (!string.IsNullOrWhiteSpace(username))
            _username = username.Trim();
        var message = $"{_username} has joined the chat";
        var body = Encoding.UTF8.GetBytes(message);
        _channel.BasicPublish(ExchangeName, string.Empty, null, body);
    }

    public void SendLeaveMessage()
    {
        var message = $"{_username} has left the chat";
        var body = Encoding.UTF8.GetBytes(message);
        _channel.BasicPublish(ExchangeName, string.Empty, null, body);
    }
}