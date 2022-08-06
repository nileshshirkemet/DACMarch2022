import banking.*;

class Program {

	public static void main(String[] args) {
		Account jack = Banker.openCurrentAccount();
		jack.deposit(20000);
		Account jill = Banker.openSavingsAccount();
		jill.deposit(15000);
		try{
			double payment = Double.parseDouble(args[0]);
			jill.transfer(payment, jack);
			//jill.transfer(payment, jill);
		}catch(InsufficientFundsException e){
			System.out.println("Payment failed due to lack of funds!");
		}catch(Exception e){
			System.out.printf("Error: %s%n", e);
		}	
		System.out.printf("Jack's Account ID is %d and Balance is %.2f%n", jack.getId(), jack.getBalance());
		System.out.printf("Jill's Account ID is %d and Balance is %.2f%n", jill.getId(), jill.getBalance());
	}
}

