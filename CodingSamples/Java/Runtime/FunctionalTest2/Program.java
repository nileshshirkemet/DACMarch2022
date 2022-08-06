import java.util.*;

class Program {

	public static void main(String[] args) {
		var shop = new Shop();
		if(args[0].equals("items")){
			var items = shop.getItems();
			/*
			for(var item : items){
				if(item.brand().equals(args[1]))
					System.out.println(item.name());
			}
			*/
			Arrays.stream(items)
				.filter(i -> i.brand().equals(args[1]))
				.map(i -> i.name())
				.forEach(System.out::println);
		}else if(args[0].equals("customers")){
			double min = Double.parseDouble(args[1]);
			var customers = shop.getCustomers();
			customers.stream()
				.filter(c -> c.purchase() >= min)
				.sorted()
				.map(c -> "*".repeat(c.rating()) + "\t" + c.id())
				.forEach(System.out::println);
		}
	}
}

