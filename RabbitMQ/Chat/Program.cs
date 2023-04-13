using Chat;
using RabbitMQ.Client;

// Create a connection to RabbitMQ server
var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = factory.CreateConnection();
// Create a channel from the connection
using var channel = connection.CreateModel();
// Create a chat handler
var handler = new ChatHandler(channel);
// Start listening for incoming messages
handler.StartListening();
// Ask for username
Console.Write("Enter your username: ");
var username = Console.ReadLine();
if (username == null) return;
// Send a message when the user joins the chat
handler.SendJoinMessage(username);
// Send a message when the user presses Ctrl+C
// telling other users that the user has left the chat
Console.CancelKeyPress += (_, _) =>
{
    handler.SendLeaveMessage();
    // Wait for the message to be sent
    Thread.Sleep(100);
};
// Start sending messages
while (true)
{
    Console.Write("Enter message: ");
    var message = Console.ReadLine();
    if (message == null) continue;
    handler.SendMessage(message);
}