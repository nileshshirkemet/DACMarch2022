@FunctionalInterface
interface Combinator {
	double combine(double x, double y);
}

class LegacySequenceBridge {

	private double first, second, third;

	public LegacySequenceBridge(double first, double second, double third) {
		this.first = first;
		this.second = second;
		this.third = third;
	}

	public native double compute(int count, double identity, Combinator rule);

	static {
		System.loadLibrary("lsbsup");
	}
}

