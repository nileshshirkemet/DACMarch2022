class Program {

	private static String client;

	private static void handleJob(int jno) {
		System.out.printf("Thread<%x> has accepted job<%d> for %s%n", Thread.currentThread().hashCode(), jno, client);
		Worker.doWork(10 * jno);
		System.out.printf("Thread<%x> has finished job<%d> for %s%n", Thread.currentThread().hashCode(), jno, client);
	}

	public static void main(String[] args) throws Exception {
		int n = args.length > 0 ? Integer.parseInt(args[0]) : 1;
		Thread child = new Thread(() -> {
			client = "Jack";
			handleJob(n);
		});
		child.setDaemon(n > 5); //JVM need not wait for a daemon (background) thread to exit
		child.start();
		client = "Jill";
		handleJob(2);
	}
}

