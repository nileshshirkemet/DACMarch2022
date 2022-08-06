package banking;

//a class defined with abstract modifier cannot be instantiated,
//it can only be used as a super-class for other classes
public abstract class Account {

	long id;
	protected double balance;

	public long getId() { return id; }

	public double getBalance() { return balance; }

	//a method defined with abstract modifier has no implementation 
	//and it must be overridden in a non-abstract subclass of this class
	//and such a method cannot be defined in a non-abstract class
	public abstract void deposit(double amount);

	public abstract void withdraw(double amount) throws InsufficientFundsException;

	//a method defined with final modifier cannot be overridden in 
	//a subclass of this class and as such JVM can skip dynamic binding
	//for handling its call
	public final void transfer(double amount, Account that) throws InsufficientFundsException {
		if(this == that)
			throw new IllegalTransferException();
		this.withdraw(amount);
		that.deposit(amount);
	}

}

