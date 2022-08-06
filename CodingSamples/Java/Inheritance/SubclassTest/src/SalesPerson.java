package payroll;

//defining sub-class of Employee (super class)
public class SalesPerson extends Employee {

	private double sales;

	public SalesPerson(int h, float r, double s) {
		super(h, r); // calling super-class constructor
		sales = s;
	}

	public double getSales() {
		return sales;
	}

	public void setSales(double value) {
		sales = value;
	}

	//overriding method by defining a method whose name, parameter types and return type
	//match with those of a method defined in the super class.
	public double income() {
		double salary = super.income();
		if(sales >= 20000)
			salary += 0.05 * sales;
		return salary;
	}
}

