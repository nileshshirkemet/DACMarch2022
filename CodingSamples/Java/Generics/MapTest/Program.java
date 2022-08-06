import java.util.*;

class Program {

	public static void main(String[] args) {
		var input = new Scanner(System.in);
		//var store = new HashMap<String, Interval>();
		var store = new TreeMap<String, Interval>();
		store.put("monday", new Interval(7, 42));
		store.put("tuesday", new Interval(6, 12));
		store.put("wednesday", new Interval(5, 33));
		store.put("thursday", new Interval(4, 54));
		store.put("friday", new Interval(3, 25));
		store.put("monday", new Interval(8, 42));
		System.out.print("Key: ");
		String key = input.next();
		Interval val = store.get(key);
		if(val != null){
			System.out.printf("Value = %s%n", val);
		}else{
			for(var pair : store.entrySet()){
				System.out.printf("%-12s%8s%n", pair.getKey(), pair.getValue());
			}
		}
		
	}
}

