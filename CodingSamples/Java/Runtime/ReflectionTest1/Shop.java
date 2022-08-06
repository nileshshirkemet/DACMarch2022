import java.util.*;

/*
A record is a refrence type which on intantiation produces a value-like
immutable object (whose state cannot be modified). Java compiler translates
a record type to a class containing private final instance fields corresponding
to the paramenters specified in the definintion of the record along with
(1) a parameterized constructor to initialize those fields
(2) methods which return values of those fields
(3) overrides for toString, hashCode and equals methods
*/
record Item(String name, String brand) {}

record Customer(String id, double purchase, int rating) implements Comparable<Customer>{
	
	public int compareTo(Customer that) {
		return this.id.compareTo(that.id);
	}
}

class Shop {

	public Item[] getItems() {
		return new Item[] {
			new Item("cpu", "intel"),
			new Item("ssd", "samsung"),
			new Item("mouse", "logitech"),
			new Item("ddr", "samsung"),
			new Item("cpu", "amd"),
			new Item("motherboard", "intel"),
			new Item("ssd", "seagate"),
			new Item("monitor", "samsung"),
			new Item("keyboard", "logitech")
		};
	}

	public Collection<Customer> getCustomers() {
		var customers = new ArrayList<Customer>();
		customers.add(new Customer("Jayesh", 48000, 3));
		customers.add(new Customer("Harshada", 63000, 4));
		customers.add(new Customer("Aishwarya", 32000, 1));
		customers.add(new Customer("Rishikesh", 85000, 5));
		customers.add(new Customer("Snehal", 54000, 2));
		customers.add(new Customer("Neeta", 72000, 4));
		customers.add(new Customer("Karishma", 23000, 2));
		customers.add(new Customer("Vishal", 39000, 4));
		customers.add(new Customer("Chetna", 92000, 5));
		customers.add(new Customer("Pankaj", 42000, 3));
		return customers;
	}
}

