//A record type produces instances commonly used for passing of
//data between methods. The C# compiler translates a record type 
//by default into a class containing read-only properties corresponding
//to its positional parameters along with a parameterized constructor
//for initializing those properties and overrides for ToString, 
//GetHashCode and Equals method. 

record Item(string Name, string Brand, decimal Price=5000, int Stock=100); //an immutable reference type record

//a value type record is mutable unless defined with read-only modifier
readonly record struct Customer(string Id, decimal Purchase, int Rating); 

class Shop
{
	public Item[] GetItems() 
    {
		return new Item[] 
        {
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

	public ICollection<Customer> GetCustomers() 
    {
		var customers = new List<Customer>();
		customers.Add(new Customer("Jayesh", 48000, 3));
		customers.Add(new Customer("Harshada", 63000, 4));
		customers.Add(new Customer("Aishwarya", 32000, 1));
		customers.Add(new Customer("Rishikesh", 85000, 5));
		customers.Add(new Customer("Snehal", 54000, 2));
		customers.Add(new Customer("Neeta", 72000, 4));
		customers.Add(new Customer("Karishma", 23000, 2));
		customers.Add(new Customer("Vishal", 39000, 4));
		customers.Add(new Customer("Chetna", 92000, 5));
		customers.Add(new Customer("Pankaj", 42000, 3));
		return customers;
	}

}
