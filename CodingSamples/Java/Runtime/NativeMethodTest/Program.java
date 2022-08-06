import java.util.*;

class Program {

	private static native long gcd(long first, long second);

	private static native void square(double[] values);

	private static native String reverse(String text);

	public static void main(String[] args) {
		System.loadLibrary("natsup"); //will look for library in locations given by java.library.path
		switch(args[0]){
			case "gcd":
				long m = Long.parseLong(args[1]);
				long n = Long.parseLong(args[2]);
				System.out.println(gcd(m, n));
				break;
			case "square":
				double[] values = Arrays.stream(args)
									.skip(1)
									.mapToDouble(Double::parseDouble)
									.toArray();
				square(values);
				Arrays.stream(values).forEach(System.out::println);
				break;
			case "reverse":
				System.out.println(reverse(args[1]));
				break;
			case "compute":
				double t1 = Double.parseDouble(args[1]);
				double t2 = Double.parseDouble(args[2]);
				double t3 = Double.parseDouble(args[3]);
				int k = Integer.parseInt(args[4]);
				var seq = new LegacySequenceBridge(t1, t2, t3);
				double r = seq.compute(k, 0, (x, y) -> x + y * y);
				System.out.println(r);
				break;
		}
	}
}

