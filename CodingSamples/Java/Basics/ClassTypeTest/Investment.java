class Investment {

	//instance fields are assigned separate values for each object
	private double payment;
	private int count;
	private boolean risk;

	//constructor is called for initializing values of instance fields
	//when a new object is created, a parameterless constructor is 
	//implicitly defined for a class if it does not explicitly define
	//any constructor
	public Investment(double amount, int period) {
		payment = amount;
		count = period;
		risk = false;
	}


	//instance method can only be called on object of the class
	public void allowRisk(boolean yes) {
		risk = yes;
	}

	public double futureValue() {
		double i = risk ? 0.08 : 0.06;
		return (payment / i) * (Math.pow(1 + i, count) - 1);
	}
}

