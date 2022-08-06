package payroll;

public class Employee {

	private int hours;
	private float rate;
	//value of static field is shared by all the instances of the class 
	//in which this field is defined
	private static int count;

	public Employee(int h, float r) {
		hours = h;
		rate = r;
		++count;
	}

	public Employee() {
		this(0, 0); //calling above constructor
	}

	//field accessor methods 
	public int getHours() {
		return hours;
	}

	public void setHours(int value) {
		hours = value;
	}

	public float getRate() {
		return rate;
	}

	public void setRate(float value) {
		rate = value;
	}

	public double income() {
		double salary = hours * rate;
		int ot = hours - 180;
		if(ot > 0)
			salary += 50 * ot;
		return salary;
	}

	//static method can be called on the class and as such
	//it can only refer to other static members of its class
	public static int countInstances() {
		return count;
	}
}



