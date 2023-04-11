using System.Text;
using RabbitMQ.Client;

var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.ExchangeDeclare("logs", ExchangeType.Fanout);

while (true)
{
    var message = GetMessage();
    var body = Encoding.UTF8.GetBytes(message);
    channel.BasicPublish("logs",
        string.Empty,
        null,
        body);
    Console.WriteLine($" [x] Sent {message}");
}

static string GetMessage()
{
    Console.Write("Elevador: ");
    var elevator = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Motivo:");
    Console.WriteLine("1 - Avaria técnica");
    Console.WriteLine("2 - Manutenção");
    Console.WriteLine("3 - Curto-circuito");
    Console.WriteLine("4 - Avaliação de segurança");
    Console.Write("Opção: ");
    var option = Convert.ToInt32(Console.ReadLine());
    var reason = option switch
    {
        1 => "Avaria Técnica",
        2 => "Manutenção",
        3 => "Curto-circuito",
        4 => "Avaliação",
        _ => "Outro"
    };
    return $"Elevador {elevator} - {reason}";
}