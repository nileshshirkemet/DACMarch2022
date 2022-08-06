class Program {

	private static ThreadLocal<String> client = new ThreadLocal<>();

	private static void handleJob(int jno) {
		System.out.printf("Thread<%x> has accepted job<%d> for %s%n", Thread.currentThread().hashCode(), jno, client.get());
		Worker.doWork(10 * jno);
		System.out.printf("Thread<%x> has finished job<%d> for %s%n", Thread.currentThread().hashCode(), jno, client.get());
	}

	public static void main(String[] args) throws Exception {
		int n = args.length > 0 ? Integer.parseInt(args[0]) : 1;
		Thread child = new Thread(() -> {
			client.set("Jack");
			handleJob(n);
		});
		child.setDaemon(n > 5); //JVM need not wait for a daemon (background) thread to exit
		child.start();
		client.set("Jill");
		handleJob(2);
	}
}

