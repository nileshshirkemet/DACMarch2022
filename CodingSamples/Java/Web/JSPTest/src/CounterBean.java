package basic.web.app;

public class CounterBean implements java.io.Serializable {

	private int step = 1;
	private long count = 0;

	public int getStep() { return step; }
	public void setStep(int value) { step = value; }

	public synchronized long getNextCount() {
		return count += step;
	}

}

