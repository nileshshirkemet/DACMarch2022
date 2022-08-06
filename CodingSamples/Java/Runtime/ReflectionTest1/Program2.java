class Program {

	private static void present(Object info) {
		Class<?> c = info.getClass();
		System.out.printf("<%s>%n", c.getName());
		for(var f : c.getDeclaredFields()){
			System.out.printf("  <%s>", f.getName());
			f.setAccessible(true);
			try{
				System.out.print(f.get(info));
			}catch(Exception e){
				System.out.print("Error");
			}
			System.out.printf("</%s>%n", f.getName());
		}
		System.out.printf("</%s>%n", c.getName());
		System.out.println();
	}

	public static void main(String[] args) {
		String uid = System.getProperty("user.name");
		present(new Customer(uid, 45000, 3));	
		present(new Item("cpu", "intel"));
		present(new Interval(3, 45));
	}
}

