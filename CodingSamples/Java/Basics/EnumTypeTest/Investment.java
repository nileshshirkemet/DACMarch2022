enum RiskLevel {
	NONE, LOW, HIGH;
}

class Investment {

	private double payment;
	private int count;
	private RiskLevel risk;

	public Investment(double amount, int period) {
		payment = amount;
		count = period;
		risk = RiskLevel.NONE;
	}


	public void allowRisk(boolean yes) {
		risk = yes ? RiskLevel.LOW : RiskLevel.NONE;
	}

	//method overloading for defining a method whose name matches with the name
	//of another method of its class which has different list of parameter types
	public void allowRisk(RiskLevel level) {
		risk = level;
	}

	public double futureValue() {
		double i;
		/*
		if(risk == RiskLevel.HIGH)
			i = 0.11;
		else if(risk == RiskLevel.LOW)
			i = 0.08;
		else
			i = 0.06;
		*/
		switch(risk){
			case HIGH:
				i = 0.11;
				break;
			case LOW:
				i = 0.08;
				break;
			default:
				i = 0.06;
		}
		return (payment / i) * (Math.pow(1 + i, count) - 1);
	}
}

