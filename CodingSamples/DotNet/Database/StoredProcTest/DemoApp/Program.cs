using System.Data;

string customerId = args[0].ToUpper();
int productNo = int.Parse(args[1]);
int quantity = int.Parse(args[2]);
using var con = new Microsoft.Data.SqlClient.SqlConnection();
con.ConnectionString = "Data Source=(localdb)\\SqlXE;Initial Catalog=Shop";
con.Open();
using var cmd = con.CreateCommand();
cmd.CommandText = "PlaceOrder";
cmd.CommandType = CommandType.StoredProcedure;
cmd.Parameters.AddWithValue("@Customer", customerId);
cmd.Parameters.AddWithValue("@Product", productNo);
cmd.Parameters.AddWithValue("@Quantity", quantity);
var orderNoParam = cmd.Parameters.Add("@OrderId", SqlDbType.Int);
orderNoParam.Direction = ParameterDirection.Output;
try
{
    cmd.ExecuteNonQuery();
    Console.WriteLine("New Order Number: {0}", orderNoParam.Value);
}
catch
{
    Console.WriteLine("Order Failed!");
}
