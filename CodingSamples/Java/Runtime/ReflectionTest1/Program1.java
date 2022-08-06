class Program {

	private static void present(Customer info) {
		System.out.println("<Customer>");
		System.out.printf("  <id>%s</id>%n", info.id());
		System.out.printf("  <purchase>%s</purchase>%n", info.purchase());
		System.out.printf("  <rating>%s</rating>%n", info.rating());
		System.out.println("</Customer>");
		System.out.println();
	}

	private static void present(Item info) {
		System.out.println("<Item>");
		System.out.printf("  <name>%s</name>%n", info.name());
		System.out.printf("  <brand>%s</brand>%n", info.brand());
		System.out.println("</Item>");
		System.out.println();

	}

	public static void main(String[] args) {
		String uid = System.getProperty("user.name");
		present(new Customer(uid, 45000, 3));	
		present(new Item("cpu", "intel"));
	}
}

