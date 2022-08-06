import java.util.*;

class Program {

	public static void main(String[] args) {
		//var store = new ArrayList<Interval>();
		var store = new LinkedList<Interval>();
		store.add(new Interval(5, 31));
		store.add(new Interval(7, 42));
		store.add(new Interval(6, 13));
		store.add(new Interval(4, 54));
		store.add(new Interval(3, 25));
		store.add(new Interval(2, 85));
		for(Interval i : store)
			System.out.println(i);
		System.out.printf("Third Interval = %s%n", store.get(2));
	}
}

