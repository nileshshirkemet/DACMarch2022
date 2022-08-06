package sales;

import java.rmi.*;
import java.util.*;

public interface OrderManager extends Remote {

	int placeOrder(String customerId, int productNo, int quantity) throws RemoteException;

	List<shopping.OrderEntity> fetchInvoice(String customerId) throws RemoteException;
}

