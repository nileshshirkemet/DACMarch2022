import java.util.*;

class Program {

	static class IntervalComparison implements Comparator<Interval> {
		public int compare(Interval x, Interval y) {
			return x.seconds() - y.seconds();
		}
	}

	public static void main(String[] args) {
		//var store = new HashSet<Interval>();
		//var store = new TreeSet<Interval>();
		var store = new TreeSet<Interval>(new IntervalComparison());
		store.add(new Interval(7, 42));
		store.add(new Interval(6, 12));
		store.add(new Interval(5, 33));
		store.add(new Interval(4, 54));
		store.add(new Interval(3, 25));
		store.add(new Interval(2, 85));
		for(Interval i : store)
			System.out.println(i);
	}
}

