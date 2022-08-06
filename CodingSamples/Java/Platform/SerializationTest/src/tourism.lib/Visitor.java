package tourism.api;

import java.util.*;

public class Visitor implements java.io.Serializable {

	String id;
	private int visitCount;
	private Date lastVisit;
	private transient long ticket; //value of this field will not be serialized

	public Visitor(String id) {
		this.id = id;
	}

	public String getId() { return id; }
	
	public int getVisitCount() { return visitCount; }
	
	public Date getLastVisit() { return lastVisit; }
	
	public long getTicket() { return ticket; }

	public void visit() {
		visitCount += 1;
		lastVisit = new Date();
		ticket = System.currentTimeMillis() % 1000000;
	}

	static final long serialVersionUID = 1L;

}

