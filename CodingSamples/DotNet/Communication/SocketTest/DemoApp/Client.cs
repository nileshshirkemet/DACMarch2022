using System.Text;
using System.Net.Sockets;

class Client
{
    public static void Run(string text)
    {
        //Step 1
        Socket server = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.Unspecified);
        server.Connect(new UnixDomainSocketEndPoint(Server.Name));
        //Step 2
        server.Send(Encoding.UTF8.GetBytes(text));
        byte[] buffer = new byte[80];
        int n = server.Receive(buffer);
        Console.WriteLine(Encoding.UTF8.GetString(buffer, 0, n));
        //Step 3
        server.Close();
    }
}