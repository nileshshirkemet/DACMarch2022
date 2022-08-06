using System.Net;

if(args.Length < 2)
    Server.Run();

string item = args[0].ToLower();
int quantity = int.Parse(args[1]);
string uri = $"http://localhost:5000/shop/{item}";
var client = new HttpClient();
try
{
    //string response = client.GetStringAsync(uri).Result;
    string response = await client.GetStringAsync(uri);
    var info = ItemInfo.Parse(response);
    if(quantity <= info.Stock)
        Console.WriteLine("Total Payment: {0:0.00}", quantity * info.Price);
    else
        Console.WriteLine("Item out of stock!");
}
catch(HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
{
    Console.WriteLine("Item not sold!");
}

