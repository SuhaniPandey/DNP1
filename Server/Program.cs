// See https://aka.ms/new-console-template for more information

using System.Net;
using System.Net.Sockets;
using System.Text;

static void Main(string[] args)
{
    Console.WriteLine("Starting server..");

    IPAddress ip = IPAddress.Parse("127.0.0.1");
    TcpListener listener = new TcpListener(ip, 5000);//listens for upcoming TCP Connections
    listener.Start();//listener is started and now it is ready for incoming requests

    Console.WriteLine("Server started..");

    while (true)//To handle multiple clients
    {
        TcpClient client = listener.AcceptTcpClient();
        new Thread(() => HandleMultipleClient(client)).Start();
    }
}

 static void HandleMultipleClient(TcpClient client)
{

    Console.WriteLine("Client connected");
    using NetworkStream stream = client.GetStream();

    // read
    while (true) {
        byte[] dataFromClient = new byte[1024];
        int bytesRead = stream.Read(dataFromClient, 0, dataFromClient.Length);
        string s = Encoding.ASCII.GetString(dataFromClient, 0, bytesRead);
        Console.WriteLine(s);
        if (s.ToLower().Equals("exit")) {
            break;
        }
        // respond
        byte[] dataToClient = Encoding.ASCII.GetBytes($"Returning {s}");
        stream.Write(dataToClient, 0, dataToClient.Length);
                
    }
}
