import java.util.stream.*;
import java.util.concurrent.*;

class Program {

	static class Computation {
	
		public long compute(int first, int last) {
			return IntStream.range(first, last + 1)
						.parallel() //split source-stream into multiple streams depending upon number of available processors
						.mapToLong(Worker::doWork)
						.sum();
		}

		public CompletableFuture<Long> computeAsync(int first, int last) {
			//A pooled thread will invoke the supplied method allowing the
			//caller thread to resume execution and acquire the result of
			//invocation at a future time after the pooled thread has 
			//completed that invocation.
			return CompletableFuture.supplyAsync(() -> compute(first, last));
		}
	
	}

	private static CompletableFuture<Void> doComputation(int limit) {
		System.out.print("Computing...");
		var c = new Computation();
		long t1 = System.nanoTime();
		return c.computeAsync(1, limit)
				.thenAccept(r -> {
					long t2 = System.nanoTime();
					System.out.println("Done!");
					System.out.printf("Result is %d, computed in %.3f seconds.%n", r, (t2 - t1) / 1e9);
				});
	}

	public static void main(String[] args) throws Exception {
		int n = Integer.parseInt(args[0]);
		var job = doComputation(n);
		while(!job.isDone()){
			System.out.print(".");
			Thread.sleep(500);
		}
	}
}

