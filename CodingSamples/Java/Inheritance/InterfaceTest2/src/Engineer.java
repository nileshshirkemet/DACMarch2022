package taxation;

public class Engineer implements TaxPayer {

	private int projects;

	public Engineer(int count) {
		projects = count;
	}

	public double annualIncome() {
		return 600000 + 50000 * projects;
	}
}

