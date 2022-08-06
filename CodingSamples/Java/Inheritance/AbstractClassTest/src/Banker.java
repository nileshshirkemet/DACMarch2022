package banking;

//factory class
public class Banker {

	private static long nid;

	//static initializer execute once after the class is loaded into the memory
	//commonly used to initialize static fields of the class
	static{
		nid = System.currentTimeMillis() % 1000000;
	}

	public static Account openCurrentAccount() {
		CurrentAccount acc = new CurrentAccount();
		acc.id = ++nid + 100000000;
		return acc;
	}

	public static Account openSavingsAccount() {
		SavingsAccount acc = new SavingsAccount();
		acc.id = ++nid + 200000000;
		return acc;
	}

	//a class that only contains static members does not require new objects
	//or subclasses and as such this class should define a private constructor 
	private Banker(){}
}

