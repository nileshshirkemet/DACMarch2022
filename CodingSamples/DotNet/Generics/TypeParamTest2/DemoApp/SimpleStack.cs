interface IPoppable<out V>
{
    V Pop();
    int Count { get; }
}

interface IPushable<in V>
{
    void Push(V item);
}

class SimpleStack<V> : IPoppable<V>, IPushable<V>
{
    //nested class (can only refer to static members of outer class)
    class Node
    {
        internal V value;
        internal Node below;

        internal Node(V value, Node below)
        {
            this.value = value;
            this.below = below;
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
}
