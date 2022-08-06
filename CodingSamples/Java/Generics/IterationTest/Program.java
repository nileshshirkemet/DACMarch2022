class Program {

	public static void main(String[] args) {
		var a = new SimpleStack<String>();
		a.push("Monday");
		a.push("Tuesday");
		a.push("Wednesday");
		a.push("Thursday");
		a.push("Friday");
		for(var i = a.iterator(); i.hasNext();)
			System.out.println(i.next());
		System.out.println("-------------------");
		var b = new SimpleStack<Interval>();
		b.push(new Interval(5, 31));
		b.push(new Interval(7, 42));
		b.push(new Interval(6, 23));
		b.push(new Interval(4, 14));
		for(Interval k : b)
			System.out.println(k);
	}
}

