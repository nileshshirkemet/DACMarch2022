class Program {

	//generic method with type parameter T
	private static <T> T select(int index, T first, T second) {
		if((index % 2) == 1)
			return first;
		return second;
	}

	private static <T extends Comparable<T>> T select(T first, T second) {
		if(first.compareTo(second) > 0)
			return first;
		return second;
	}

	public static void main(String[] args) {
		if(args.length > 0){
			int s = Integer.parseInt(args[0]);
			String ss = select(s, "Monday", "Friday");
			System.out.printf("Selected String = %s%n", ss);
			double sd = select(s, 4.56, 5.43);
			System.out.printf("Selected double = %s%n", sd);
			Interval si = select(s, new Interval(3, 45), new Interval(2, 30));
			System.out.printf("Selected Interval = %s%n", si);
			//String x = select(s, "Sunday", 9.72);
		}else{
			String ss = select("Monday", "Friday");
			System.out.printf("Selected String = %s%n", ss);
			double sd = select(4.56, 5.43);
			System.out.printf("Selected double = %s%n", sd);
			Interval si = select(new Interval(3, 45), new Interval(2, 30));
			System.out.printf("Selected Interval = %s%n", si);

		}
	}
}

