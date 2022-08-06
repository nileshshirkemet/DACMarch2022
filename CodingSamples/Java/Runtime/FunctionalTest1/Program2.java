
class Program {


	private static float safeScheme(int n) {
		return n < 3 ? 0.05f : 0.07f;
	}

	public static void main(String[] args) {
		var input = new java.util.Scanner(System.in);
		System.out.print("Enter yearly payment and number of years: ");
		double p = input.nextDouble();
		int n = input.nextInt();
		var inv = new Investment(p, n);
		//passing compatible method-reference in place of functional interface
		System.out.printf("Future value in no-risk investment: %.2f%n", inv.futureValue(Program::safeScheme));
		//passing lambda-expression in place of functional interface
		System.out.printf("Future value in high-risk investment: %.2f%n", inv.futureValue(y -> 0.09f + 0.005f * y));
	}
}

