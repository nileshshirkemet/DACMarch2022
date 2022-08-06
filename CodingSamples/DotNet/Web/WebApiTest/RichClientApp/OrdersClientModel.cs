using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

namespace RichClientApp
{
    public class OrderResource
    {
        public int OrderNo { get; set; }

        public string? OrderDate { get; set; }

        public string CustomerId { get; set; } = null!;

        public int ProductNo { get; set; }

        public int Quantity { get; set; }
    }


    public class OrdersClientModel
    {
        private HttpClient client = new HttpClient();

        public async Task<List<OrderResource>?> GetOrdersAsync(string customerId)
        {
            return await client.GetFromJsonAsync<List<OrderResource>>($"{Settings.Default.ServiceUri}{customerId}");
        }

        public async Task<int> PostOrderAsync(OrderResource resource)
        {
            var response = await client.PostAsJsonAsync(Settings.Default.ServiceUri, resource);
            if (response.IsSuccessStatusCode)
            {
                var order = await response.Content.ReadFromJsonAsync<OrderResource>();
                return order?.OrderNo ?? 0;
            }
            return 0;
        }
    }
}
