import java.util.stream.*;

class Program {

	static class Computation {
	
		public long compute(int first, int last) {
			return IntStream.range(first, last + 1)
						.mapToLong(Worker::doWork)
						.sum();
		}
	
	}


	private static void doComputation(int limit) {
		System.out.print("Computing...");
		var c = new Computation();
		long t1 = System.nanoTime();
		long r = c.compute(1, limit);
		long t2 = System.nanoTime();
		System.out.println("Done!");
		System.out.printf("Result is %d, computed in %.3f seconds.%n", r, (t2 - t1) / 1e9);
	}

	public static void main(String[] args) throws Exception {
		int n = Integer.parseInt(args[0]);
		doComputation(n);
	}
}

