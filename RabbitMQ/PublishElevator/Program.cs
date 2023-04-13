using System.Text;
using RabbitMQ.Client;

var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

const string exchangeName = "elevator-log";
channel.ExchangeDeclare(exchangeName, ExchangeType.Fanout);

while (true)
{
    Console.Write("Elevador: ");
    if (!int.TryParse(Console.ReadLine(), out var elevator)) continue;
    Console.WriteLine("Motivo:");
    Console.WriteLine("1 - Avaria técnica");
    Console.WriteLine("2 - Manutenção");
    Console.WriteLine("3 - Curto-circuito");
    Console.WriteLine("4 - Avaliação de segurança");
    Console.Write("Opção: ");
    if (!int.TryParse(Console.ReadLine(), out var option)) continue;
    var reason = option switch
    {
        1 => "Avaria Técnica",
        2 => "Manutenção",
        3 => "Curto-circuito",
        4 => "Avaliação",
        _ => "Outro"
    };
    var message = $"Elevador {elevator} - {reason}";
    var body = Encoding.UTF8.GetBytes(message);
    channel.BasicPublish(exchangeName,
        string.Empty,
        null,
        body);
    Console.WriteLine($" [x] Sent {message}");
}