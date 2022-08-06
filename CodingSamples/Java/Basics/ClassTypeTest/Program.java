class Program {

	public static void main(String[] args) {
		System.out.println("Welcome Investor.");
		double p = Double.parseDouble(args[0]);
		int n = Integer.parseInt(args[1]);
		Investment inv = new Investment(p, n);  //creating a new instance of a class type on heap using parameterized constructor
		System.out.printf("Future value for no-risk investment: %.2f%n", inv.futureValue());
		inv.allowRisk(true);
		System.out.printf("Future value for low-risk investment: %.2f%n", inv.futureValue());
	}
}

