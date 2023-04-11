using Chat;

// Create thread for receiving messages
var receiver = new Thread(Receiver.ReceiveMessage)
{
    IsBackground = true
};

receiver.Start();
Sender.SendMessage();
receiver.Join();

Console.WriteLine(" Press [enter] to exit.");
Console.ReadLine();