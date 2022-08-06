record ItemInfo(double price, int stock){

	//text="price=19000,stock=100"
	public static ItemInfo parse(String text) {
		String[] parts = text.split(",");
		double p = Double.parseDouble(parts[0].substring(6));
		int s = Integer.parseInt(parts[1].substring(6));
		return new ItemInfo(p, s);
	}
}

