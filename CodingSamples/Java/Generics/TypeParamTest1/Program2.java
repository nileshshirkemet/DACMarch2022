class Program {

	private static Object select(int index, Object first, Object second) {
		if((index % 2) == 1)
			return first;
		return second;
	}

	public static void main(String[] args) {
		if(args.length > 0){
			int s = Integer.parseInt(args[0]);
			String ss = (String)select(s, "Monday", "Friday");
			System.out.printf("Selected String = %s%n", ss);
			//implicit conversion of a primitive type (double) value
			//to an instance of its wrapper (java.lang.Double) is called auto-boxing
			double sd = (double)select(s, 4.56, 5.43);
			System.out.printf("Selected double = %s%n", sd);
			Interval si = (Interval)select(s, new Interval(3, 45), new Interval(2, 30));
			System.out.printf("Selected Interval = %s%n", si);
			String x = (String)select(s, "Sunday", 9.72);
		}
	}
}

