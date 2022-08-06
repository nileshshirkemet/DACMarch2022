string customerId = args[0].ToUpper();
int productNo = int.Parse(args[1]);
int quantity = int.Parse(args[2]);
using var con = new MySql.Data.MySqlClient.MySqlConnection();
con.ConnectionString = "Data Source=localhost;Database=shop;User ID=dbpro;Password=Dbpro@789";
con.Open();
var cmd = con.CreateCommand();
cmd.Transaction = con.BeginTransaction();
try
{
    cmd.CommandText = "UPDATE Counters SET CurrentValue=CurrentValue+1 WHERE Id='order'";
    cmd.ExecuteNonQuery();
    cmd.CommandText = "SELECT SeedValue+CurrentValue FROM Counters WHERE Id='order'";
    long orderNo = (long)cmd.ExecuteScalar();
    cmd.CommandText = "INSERT INTO OrderDetail VALUES(@ordno, @orddt, @custid, @pno, @qty)";
    cmd.Parameters.AddWithValue("@ordno", orderNo);
    cmd.Parameters.AddWithValue("@orddt", DateTime.Today);
    cmd.Parameters.AddWithValue("@custid", customerId);
    cmd.Parameters.AddWithValue("@pno", productNo);
    cmd.Parameters.AddWithValue("@qty", quantity);
    cmd.ExecuteNonQuery();
    cmd.Transaction.Commit();
    Console.WriteLine("New Order Number: {0}", orderNo);
}
catch
{
    cmd.Transaction.Rollback();
    Console.WriteLine("Order Failed!");
}
