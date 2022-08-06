//A class that does not explicitly extends any other class implicitly extends
//java.lang.Object which is the root type for all reference types in Java and 
//as such any type supports implicit conversion to java.lang.Object
class Interval {

	private int min;
	private int sec;

	public Interval(int m, int s) {
		min = m + s / 60;
		sec = s % 60;
	}
	
	public int minutes() { return min; }

	public int seconds() { return sec; }

	public int time() { return 60 * min + sec; }

	//overriding java.lang.Object methods

	public String toString() {
		if(sec < 10)
			return min + ":0" + sec;
		return min + ":" + sec;
	}

	public int hashCode() {
		return min + sec;
	}

	public boolean equals(Object other) {
		if(other instanceof Interval){
			Interval that = (Interval)other;
			return this.min == that.min && this.sec == that.sec;
		}
		return false;
	}
}

