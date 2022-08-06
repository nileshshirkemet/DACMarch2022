//functional interface
interface Interest {
	float forPeriod(int years);
}

class Investment {

	private final double payment;
	private final int count;

	public Investment(double payment, int count) {
		this.payment = payment;
		this.count = count;
	}

	public double payment() { return payment; }

	public int count() { return count; }

	public double futureValue(Interest rate) {
		float i = rate.forPeriod(count);
		return (payment / i) * (Math.pow(1 + i, count) - 1);
	}
}

