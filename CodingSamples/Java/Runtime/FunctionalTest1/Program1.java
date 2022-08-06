
class Program {

	static class SafeScheme implements Interest {
		public float forPeriod(int n) {
			return n < 3 ? 0.05f : 0.07f; 
		}
	
	}

	public static void main(String[] args) {
		var input = new java.util.Scanner(System.in);
		System.out.print("Enter yearly payment and number of years: ");
		double p = input.nextDouble();
		int n = input.nextInt();
		var inv = new Investment(p, n);
		System.out.printf("Future value in no-risk investment: %.2f%n", inv.futureValue(new SafeScheme()));
	}
}

