
class SimpleStack<V> 
{
    class Node
    {
        internal V value;
        internal Node below;

        internal Node(V value, Node below)
        {
            this.value = value;
            this.below = below;
        }

        internal Node Skip(int steps)
        {
            Node n = this;
            for(int i = 0; i < steps; ++i)
                n = n.below;
            return n;
        }
    }

    private Node top;

    public int Count { get; private set; }

    public void Push(V item)
    {
        top = new Node(item, top);
        ++Count;
    }

    public V Pop()
    {
        V item = top.value;
        top = top.below;
        --Count;
        return item;
    }

    //To enable standard enumeration (iteration) on an object, its type
    //must contain an accessible GetEnumerator() method whose return type
    //must expose MoveNext() method and Current property as defined in
    //System.Collections.Generic.IEnumerator<T> interface
    public IEnumerator<V> GetEnumerator()
    {
        for(Node n = top; n != null; n = n.below)
        {
            //the 'yield return' statement allows a method to return multiple
            //values one-by-one through an auto-generated implementation of
            //a standard enumeration interface specified in its return type
            yield return n.value;
        }
    }

    //indexer is a special property implemented to enable array like indexing 
    //for an object
    public V this[int index]
    {
        get { return top.Skip(index).value; }
        set { top.Skip(index).value = value; }
    }
}
