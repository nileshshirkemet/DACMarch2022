class Program {

	private static String select(int index, String first, String second) {
		if((index % 2) == 1)
			return first;
		return second;
	}

	private static double select(int index, double first, double second) {
		if((index % 2) == 1)
			return first;
		return second;
	}

	private static Interval select(int index, Interval first, Interval second) {
		if((index % 2) == 1)
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
		}
	}
}

