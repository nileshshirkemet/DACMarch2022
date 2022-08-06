package modern.web.app;

import sales.OrderManager;
import shopping.OrderEntity;
import java.rmi.*;
import java.util.*;
import jakarta.ws.rs.*;
import jakarta.ws.rs.core.*;

@Path("/orders")
public class OrderManagerAPI {

	@GET
	@Path("/{id}")
	@Produces(MediaType.APPLICATION_JSON)
	public Response readOrders(@PathParam("id") String customer) {
		try{
			var stub = (OrderManager)Naming.lookup("rmi://localhost:6000/orderManager");
			var orders = stub.fetchInvoice(customer);
			if(orders.size() == 0)
				return Response.status(404).build();
			return Response.ok(orders).build();
		}catch(Exception e){
			return Response.status(500).build();
		}
	}

	@POST
	@Consumes(MediaType.APPLICATION_JSON)
	@Produces(MediaType.APPLICATION_JSON)
	public Response createOrder(OrderEntity info) {
		try{
			var stub = (OrderManager)Naming.lookup("rmi://localhost:6000/orderManager");
			int orderNo = stub.placeOrder(info.getCustomerId(), info.getProductNo(), info.getQuantity());
			info.setOrderNo(orderNo);
			return Response.ok(info).build();
		}catch(Exception e){
			return Response.status(500).build();
		}
	}
}

