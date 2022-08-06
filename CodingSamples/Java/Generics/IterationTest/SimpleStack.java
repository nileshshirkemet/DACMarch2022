import java.util.Iterator;

class SimpleStack<V> implements Iterable<V> {

	private Node top;

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

	public Iterator<V> iterator() {
		//int count = 5;
		//returning an instance of an inner local anonymous class which implements Iterator<V>
		return new Iterator<V>() {
			
			Node current = top;

			public boolean hasNext() {
				return current != null; // && count > 0;
			}

			public V next() {
				V result = current.value;
				current = current.below;
				//--count;
				return result;
			}
		};
	}
}

