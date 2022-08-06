import taxation.*;

class Program {

	//nested member class is defined inside of another class with static modifier
	static class Auditor implements AutoCloseable {
		
		public Auditor() {
			System.out.println("Acquiring resources...");
		}

		public double audit(TaxPayer person, String id) {
			if(id.length() < 4)
				throw new IllegalArgumentException("Invalid ID");
			return person.incomeTax() + 500;
		}

		public void close() {
			System.out.println("Releasing resources...");
		}
	}

	private static void doAudit(String name, int count) {
		TaxPayer emp = name.equalsIgnoreCase("jack") ? new Engineer(count) : new Programmer(count);
		try(var a = new Auditor()){ 
			System.out.printf("Total Payment: %.2f%n", a.audit(emp, name));
		}//compiler will automatially attach a finally block with a.close()
	}

	public static void main(String[] args) {
		try{
			String m = args[0];
			int n = Integer.parseInt(args[1]);
			doAudit(m, n);

		}catch(Exception e){
			System.out.printf("Error: %s%n", e);
		}
	}
}

