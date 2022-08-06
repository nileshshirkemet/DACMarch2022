class Program {

	public static void main(String[] args) {
		SimpleStack<String> a = new SimpleStack<String>();
		a.push("Monday");
		a.push("Tuesday");
		a.push("Wednesday");
		a.push("Thursday");
		a.push("Friday");
		//a.push(12.3);
		while(!a.empty())
			System.out.println(a.pop());
		System.out.println("-----------------");
		SimpleStack<Double> b = new SimpleStack<>(); //type inference from declaration
		b.push(23.1);
		b.push(45.2);
		b.push(56.3);
		b.push(31.4);
		while(!b.empty())
			System.out.println(b.pop());
		System.out.println("-----------------");
		SimpleStack<Object> c = new SimpleStack<>();
		c.push("Sunday");
		c.push(97.5);
		c.push(1234);
		while(!c.empty())
			System.out.println(c.pop());
	}
}

