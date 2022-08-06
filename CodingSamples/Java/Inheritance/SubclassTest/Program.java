//importing a type name from another package enables the compiler to expand
//its unqualified name to its fully qualified (imported) name
import payroll.Employee;
import payroll.SalesPerson;

class Program {

	private static double tax(Employee emp) {
		//JVM uses dynamic-binding by default to call an instance method
		//i.e it invokes the implementation of the method provided by the 
		//class from which the referred object is instantiated
		double i = emp.income();
		return i > 10000 ? 0.15 * (i - 10000) : 0;
	}

	private static double bonus(Employee emp) {
		if(emp instanceof SalesPerson)
			return 0;
		return 0.1 * emp.income();
	}

	public static void main(String[] args) {
		Employee jack = new Employee();
		jack.setHours(186);
		jack.setRate(52);
		SalesPerson jill = new SalesPerson(186, 52, 48000);
		System.out.printf("Jack's Income is %.2f and Tax is %.2f%n", jack.income(), tax(jack));
		System.out.printf("Jill's Income is %.2f and Tax is %.2f%n", jill.income(), tax(jill));
		System.out.printf("Jack's Bonus: %.2f%n", bonus(jack));
		System.out.printf("Jill's Bonus: %.2f%n", bonus(jill));
		System.out.printf("Number of Employees = %d%n", Employee.countInstances());
	}
}

