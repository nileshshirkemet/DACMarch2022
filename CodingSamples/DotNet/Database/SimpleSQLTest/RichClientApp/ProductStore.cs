using System.ComponentModel;
using Microsoft.Data.SqlClient;

namespace RichClientApp
{
    public class ProductStore
    {
        const string connectionString = "Data Source=(localdb)\\SqlXE;Initial Catalog=Shop";

        public void LoadProducts(IBindingList source)
        {
            using var con = new SqlConnection(connectionString);
            con.Open();
            using var cmd = con.CreateCommand();
            cmd.CommandText = "SELECT ProductNo, Price FROM ProductInfo";
            using var row = cmd.ExecuteReader();
            while(row.Read())
            {
                source.Add(new Product
                { 
                    ProductNo = row.GetInt32(0),
                    Price = row.GetDecimal(1)
                });
            }
        }

        public void UpdateProduct(Product entry)
        {
            using var con = new SqlConnection(connectionString);
            con.Open();
            using var cmd = con.CreateCommand();
            cmd.CommandText = $"UPDATE ProductInfo SET Price = {entry.Price} WHERE ProductNo = {entry.ProductNo}"; ;
            cmd.ExecuteNonQuery();
        }

        public void LoadOrders(Product entry, IBindingList source)
        {
            using var con = new SqlConnection(connectionString);
            con.Open();
            using var cmd = con.CreateCommand();
            cmd.CommandText = $"SELECT CustomerId, Quantity, OrderDate FROM OrderDetail WHERE ProductNo={entry.ProductNo}";
            using var row = cmd.ExecuteReader();
            while(row.Read())
            {
                source.Add(new ProductOrder 
                { 
                    CustomerId = row.GetString(0),
                    Quantity = row.GetInt32(1),
                    OrderDate = row.GetDateTime(2)
                });
            }
        }
    }
}

