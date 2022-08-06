using Sales;
using Grpc.Core;
using Microsoft.AspNetCore.Mvc;

namespace ModernWebApp.Controllers;

using Models;

[ApiController]
[Route("/api/orders")]
public class OrdersController : ControllerBase
{
    private OrderManager.OrderManagerClient _client;

    public OrdersController(OrderManager.OrderManagerClient client) => _client = client;

    [Route("{id}")]
    public async Task<ActionResult<List<OrderResource>>> ReadOrders(string id)
    {
        var request = new CustomerInput { CustomerName = id };
        try
        {
            using var reply = _client.FetchInvoice(request);
            var orders = new List<OrderResource>();
            await foreach(var order in reply.ResponseStream.ReadAllAsync())
            {
                orders.Add(new OrderResource 
                {
                    ProductNo = order.ItemCode,
                    Quantity = order.ItemCount,
                    OrderDate = order.DateOfOrder
                });
            }
            if(orders.Count == 0)
                return NotFound();
            return orders;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
            return StatusCode(500);
        }
    }

    [HttpPost]
    public async Task<ActionResult<OrderResource>> CreateOrder(OrderResource resource)
    {
        try
        {
            var request = new OrderInput 
            {
                CustomerName = resource.CustomerId,
                ItemCode = resource.ProductNo,
                ItemCount = resource.Quantity
            };
            var reply = await _client.PlaceOrderAsync(request);
            resource.OrderNo = reply.ConfirmationCode;
            return resource;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
            return StatusCode(500);
        }
    }
}
