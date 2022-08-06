using System.Net.Sockets;

string item = args[1].ToLower();
int quantity = int.Parse(args[2]);
var client = new TcpClient(args[0], 4000);
var channel = client.GetStream();
var reader = new StreamReader(channel);
var writer = new StreamWriter(channel) { AutoFlush = true };
Console.WriteLine(reader.ReadLine());
writer.WriteLine(item);
string response = reader.ReadLine();
if(response != null)
{
    var info = ItemInfo.Parse(response);
    if(quantity <= info.Stock)
        Console.WriteLine("Total Payment: {0:0.00}", quantity * info.Price);
    else
        Console.WriteLine("Item out of stock!");
}
else
{
    Console.WriteLine("Item not sold!");
}
writer.Close();
reader.Close();
client.Close();

