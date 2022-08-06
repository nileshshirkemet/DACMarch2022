class Program
{
    private static void PrintStack(IPoppable<object> store)
    {
        while(store.Count > 0)
            Console.WriteLine(store.Pop());
    }

    public static void Main(string[] args)
    {
        SimpleStack<string> a = new SimpleStack<string>();
        a.Push("Monday");
        a.Push("Tuesday");
        a.Push("Wednesday");
        a.Push("Thursday");
        a.Push("Friday");
        //a.Push(1.23);
        PrintStack(a);
        Console.WriteLine("-----------------------");
        SimpleStack<Interval> b = new SimpleStack<Interval>();
        b.Push(new Interval(5, 31));
        b.Push(new Interval(7, 42));
        b.Push(new Interval(6, 53));
        b.Push(new (3, 14));
        PrintStack(b);
        Console.WriteLine("-----------------------");
        SimpleStack<object> c = new SimpleStack<object>();
        c.Push("Sunday");
        c.Push(1.23);
        c.Push(new Interval(4, 25));
        PrintStack(c);
        //SimpleStack<double> d = new SimpleStack<double>();
        //PrintStack(d);
    }
}
