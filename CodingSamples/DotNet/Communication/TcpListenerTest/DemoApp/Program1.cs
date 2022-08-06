using System.Net;
using System.Net.Sockets;

var listener = new TcpListener(IPAddress.Any, 4000);
listener.Start();
Service(listener);

void Service(TcpListener listener)
{
    Shop shop = Shop.Open("store.xml");
    for(;;)
    {
        var client = listener.AcceptTcpClient();
        var channel = client.GetStream();
        var reader = new StreamReader(channel);
        var writer = new StreamWriter(channel);
        try
        {
            client.ReceiveTimeout = 20000;
            writer.WriteLine("Welcome to CitiTek Computers");
            writer.Flush();
            string item = reader.ReadLine();
            string info = shop.GetItemInfo(item);
            if(info is not null)
            {
                writer.WriteLine(info);
                writer.Flush();
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine("Communication Failure: {0}", ex.Message);
        }
        writer.Close();
        reader.Close();
        client.Close();
    }
}