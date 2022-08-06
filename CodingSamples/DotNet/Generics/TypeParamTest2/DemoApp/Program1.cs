class Program
{
    public static void Main(string[] args)
    {
        SimpleStack<string> a = new SimpleStack<string>();
        a.Push("Monday");
        a.Push("Tuesday");
        a.Push("Wednesday");
        a.Push("Thursday");
        a.Push("Friday");
        //a.Push(1.23);
        while(a.Count > 0)
            Console.WriteLine(a.Pop());
        Console.WriteLine("-----------------------");
        SimpleStack<Interval> b = new SimpleStack<Interval>();
        b.Push(new Interval(5, 31));
        b.Push(new Interval(7, 42));
        b.Push(new Interval(6, 53));
        b.Push(new (3, 14));
        while(b.Count > 0)
            Console.WriteLine(b.Pop());
        Console.WriteLine("-----------------------");
        SimpleStack<object> c = new SimpleStack<object>();
        c.Push("Sunday");
        c.Push(1.23);
        c.Push(new Interval(4, 25));
        while(c.Count > 0)
            Console.WriteLine(c.Pop());       
    }
}
