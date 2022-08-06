package finance;

public class CarLoan extends PersonalLoan {

	@Override
	@MaxDuration(4)
	public float common(double amount, int period) {
		return super.common(amount, period) + 0.5f;
	}	
}

