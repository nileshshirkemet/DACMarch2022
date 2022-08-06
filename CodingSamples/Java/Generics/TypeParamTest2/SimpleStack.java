class SimpleStack<V> {

	private Node top;

	//inner member class is defined inside of another class without static modifier
	class Node {
		
		V value;
		Node below;
		
		Node(V val) {
			value = val;
			below = top;
		}

	}

	public void push(V val) {
		top = new Node(val);
	}

	public V pop() {
		V result = top.value;
		top = top.below;
		return result;
	}

	public boolean empty() {
		return top == null;
	}

}

