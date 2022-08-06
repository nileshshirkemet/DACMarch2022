package classic.web.app;

import java.sql.*;
import java.util.*;

public class CustomerBean implements java.io.Serializable {

	private String id;
	private String password;

	public final String getId() { return id; }
	public final void setId(String value) { id = value; }

	public final String getPassword() { return password; }
	public final void setPassword(String value) { password = value; }

	public boolean authenticate() throws SQLException {
		try(var con = DB.connect()){
			var pstmt = con.prepareStatement("select count(cust_id) from customers where cust_id=? and pwd=?");
			pstmt.setString(1, id);
			pstmt.setString(2, password);
			var rs = pstmt.executeQuery();
			rs.next();
			int count = rs.getInt(1);
			rs.close();
			pstmt.close();
			if(count == 1)
				return true;
			id = password = null;
			return false;
		}
	}

	public List<CustomerOrder> getOrders() throws SQLException {
		var orders = new ArrayList<CustomerOrder>();
		try(var con = DB.connect()){
			var pstmt = con.prepareStatement("select pno, qty, ord_date from orders where cust_id=?");
			pstmt.setString(1, id);
			var rs = pstmt.executeQuery();
			while(rs.next())
				orders.add(new CustomerOrder(rs));
			rs.close();
			pstmt.close();
		}
		return orders;
	}

}

