package sales;

import shopping.*;
import java.rmi.*;
import java.util.*;
import javax.persistence.*;

public class OrderManagerService extends java.rmi.server.UnicastRemoteObject implements OrderManager {

	public OrderManagerService() throws RemoteException {
		super(6000); //export this object in TCP/IP port 6000
	}

	public int placeOrder(String customerId, int productNo, int quantity) throws RemoteException {
		var emf = Persistence.createEntityManagerFactory("SalesPU");
		var em = emf.createEntityManager();
		try{
			var tx = em.getTransaction();
			tx.begin();
			var ctr = em.find(CounterEntity.class, "orders");
			int orderNo = ctr.getNextValue() + 1000;
			var ord = new OrderEntity();
			ord.setOrderNo(orderNo);
			ord.setOrderDate(new Date());
			ord.setCustomerId(customerId);
			ord.setProductNo(productNo);
			ord.setQuantity(quantity);
			em.persist(ord); //insert the state of the entity into database
			tx.commit(); //save all changes
			return orderNo;
		}finally{
			em.close();
		}
	}

	public List<OrderEntity> fetchInvoice(String customerId) throws RemoteException {
		var emf = Persistence.createEntityManagerFactory("SalesPU");
		var em = emf.createEntityManager();
		try{
			var query = em.createQuery("SELECT e FROM OrderEntity e WHERE e.customerId=?1", OrderEntity.class);
			query.setParameter(1, customerId);
			return query.getResultList();
		}finally{
			em.close();
		}
	}

	public static void main(String[] args) throws Exception {
		var naming = java.rmi.registry.LocateRegistry.createRegistry(6000);
		naming.bind("orderManager", new OrderManagerService());
	}
}

