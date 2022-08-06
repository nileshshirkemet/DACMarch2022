class Program {

	//private static void printStack(SimpleStack<? extends Object> store) {
	private static void printStack(SimpleStack<?> store) {
		while(!store.empty())
			System.out.println(store.pop());
		//store.push("Jack");
	}

	public static void main(String[] args) {
		SimpleStack<String> a = new SimpleStack<String>();
		a.push("Monday");
		a.push("Tuesday");
		a.push("Wednesday");
		a.push("Thursday");
		a.push("Friday");
		printStack(a);
		System.out.println("-----------------");
		SimpleStack<Double> b = new SimpleStack<>(); 
		b.push(23.1);
		b.push(45.2);
		b.push(56.3);
		b.push(31.4);
		printStack(b);
		System.out.println("-----------------");
		SimpleStack<Object> c = new SimpleStack<>();
		c.push("Sunday");
		c.push(97.5);
		c.push(1234);
		printStack(c);
	}
}

