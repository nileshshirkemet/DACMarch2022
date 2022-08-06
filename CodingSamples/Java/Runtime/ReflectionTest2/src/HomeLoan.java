package finance;

public class HomeLoan {

	public float common(double amount, int period) {
		return period < 5 ? 9.0f : 8.5f;
	}

	@MaxDuration(value=12)
	public float woman(double amount, int period) {
		return common(amount, period) - 1;
	}

	public float soldier(double amount, int period) {
		return common(amount, period) - 4;
	}
}

