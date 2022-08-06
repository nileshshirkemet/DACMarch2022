import java.lang.reflect.Method;

class Program {

	public static void main(String[] args) throws Exception {
		double p = Double.parseDouble(args[0]);
		Class<?> c = Class.forName(args[1]);
		Object policy = c.getConstructor().newInstance(); //dynamic activation
		Method scheme = c.getMethod(args[2], double.class, int.class);
		int m = 10;
		for(int n = 1; n <= m; ++n){
			float rate = (float)scheme.invoke(policy, p, n); //late binding
			float i = rate / 1200;
			double emi = p * i / (1 - Math.pow(1 + i, -12 * n));
			System.out.printf("%d\t%.2f%n", n, emi);
		}
	}
}

