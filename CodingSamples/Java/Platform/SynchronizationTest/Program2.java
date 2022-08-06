class Program {

	static class JointAccount {
		
		private int balance;

		public int balance() { return balance; }

		public boolean withdraw(int amount) {
			boolean result = false;
			//A thread can enter a synchronized block by locking the monitor of
			//the specified object. Only one thread can lock the monitor of a given
			//object at a time while other threads must wait until this thread
			//unlocks the monitor by exiting the synchronized block.
			synchronized(this) {
				if(balance >= amount) {
					Worker.doWork(amount / 500);
					balance -= amount;
					result = true;
				}
			}
			return result;
		}

		public synchronized void deposit(int amount) {
			Worker.doWork(amount / 500);
			balance += amount;
			//allow a thread waiting on the monitor of this object
			//to resume execution
			this.notify();
		}

		public synchronized void withdrawAfterDeposit(int amount) throws InterruptedException {
			do{
				//temporarily unlock the monitor of this object and wait for
				//some other thread to notify the monitor of this object
				this.wait();
			}while(balance < amount);
			balance -= amount;
		}

	}

	public static void main(String[] args) throws Exception {
		var acc = new JointAccount();
		acc.deposit(5000);
		System.out.println("Joint-account opened for Jack and Jill.");
		System.out.printf("Initial balance = %d%n", acc.balance());
		Thread child = new Thread(() -> {
			System.out.println("Jack is withdrawing 3000 from joint account...");
			if(acc.withdraw(3000) == false)
				System.out.println("Jack's withdraw operation failed!");
		});
		child.start();
		System.out.println("Jill is withdrawing 4000 from joint account...");
		if(acc.withdraw(4000) == false)
			System.out.println("Jill's withdraw operation failed!");
		child.join(); //wait for child to exit
		System.out.printf("Final balance = %d%n", acc.balance());
	}
}

