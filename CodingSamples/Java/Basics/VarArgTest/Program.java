class Deviation {
	public double result;
}

class Program {

	/*
	private static double average(double first, double second) {
		return (first + second) / 2; 
	}

	private static double average(double first, double second, double third) {
		return (first + second + third) / 3; 
	}
	*/

	//variadic method can accept variable number of arguments through its last (var-arg) 	parameter
	private static double average(double first, double second, double... remaining) {
		double total = first + second;
		//for-each style loop
		for(double value : remaining){
			total += value;
		}
		return total / (2 + remaining.length);
	}

	private static double averageWithDeviation(double first, double second, Deviation dev) {
		dev.result = first > second ? (first - second) / 2 : (second - first) / 2;
		return (first + second) / 2;
	}

	public static void main(String[] args){
		System.out.printf("Average of two values: %f%n", average(23.7, 31.2));
		System.out.printf("Average of three values: %f%n", average(23.7, 31.2, 19.8));
		System.out.printf("Average of five values: %f%n", average(23.7, 31.2, 19.8, 36.9, 15.6));
		if(args.length > 1){
			double x = Double.parseDouble(args[0]);
			double y = Double.parseDouble(args[1]);
			Deviation d = new Deviation();
			double a = averageWithDeviation(x, y, d);
			System.out.printf("Average of given values is %f with deviation of %f%n", a, d.result);
		}
	}
}


