class Program {

	private static double invest(double payment, int count, boolean risky) {
		double i = risky ? 0.08 : 0.06;
		return (payment / i) * (Math.pow(1 + i, count) - 1);
	}

	public static void main(String[] args) {
		System.out.println("Welcome Investor.");
		double p = Double.parseDouble(args[0]);
		int n = Integer.parseInt(args[1]);
		System.out.printf("Future value for no-risk investment: %.2f%n", invest(p, n, false));
		System.out.printf("Future value for low-risk investment: %.2f%n", invest(p, n, true));
	}
}

