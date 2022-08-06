class Program {

	public static void main(String[] args) {
		System.out.println("Welcome Investor.");
		double p = Double.parseDouble(args[0]);
		int n = Integer.parseInt(args[1]);
		Investment inv = new Investment(p, n); 
		System.out.printf("Future value for no-risk investment: %.2f%n", inv.futureValue());
		inv.allowRisk(true);
		System.out.printf("Future value for low-risk investment: %.2f%n", inv.futureValue());
		inv.allowRisk(RiskLevel.HIGH);
		System.out.printf("Future value for high-risk investment: %.2f%n", inv.futureValue());
	}
}

