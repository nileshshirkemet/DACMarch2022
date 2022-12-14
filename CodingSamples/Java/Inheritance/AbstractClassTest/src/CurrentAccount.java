package banking;

//a class defined with final modifier cannot be used as a super-class
final class CurrentAccount extends Account {

	public void deposit(double amount) {
		if(balance < 0)
			amount *= 0.9;
		balance += amount;
	}

	public void withdraw(double amount) throws InsufficientFundsException {
		balance -= amount;
	}
	
}

