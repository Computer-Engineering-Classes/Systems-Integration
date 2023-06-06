using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

// declare a fan-out exchange
channel.ExchangeDeclare("sensor-logs", ExchangeType.Fanout);

// bind the queue to the exchange
var queueName = channel.QueueDeclare().QueueName;
channel.QueueBind(queueName, "sensor-logs", string.Empty);

var consumer = new EventingBasicConsumer(channel);
consumer.Received += (_, args) =>
{
    var message = Encoding.UTF8.GetString(args.Body.ToArray());
    var msgParts = message.Split(':');
    var sensorType = msgParts[0];
    var sensorValue = double.Parse(msgParts[1]);
    switch (sensorType)
    {
        case "rpm" when sensorValue is < 1000 or > 6000:
            Console.WriteLine($"RPM out of range: {sensorValue}");
            break;
        case "l/km" when sensorValue > 40:
            Console.WriteLine($"Fuel consumption out of range: {sensorValue}");
            break;
    }
};

channel.BasicConsume(queueName, true, consumer);

while (true)
{
    Console.WriteLine("Press any key to exit");
    Console.ReadKey();
    break;
}